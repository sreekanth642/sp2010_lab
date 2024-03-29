set-alias stsadm "C:\Program Files\Common Files\Microsoft Shared\Web Server Extensions\14\BIN\stsadm.exe"

$scriptPath = Split-Path $myInvocation.MyCommand.Path
Write-Host ScriptPath = $scriptPath

Write-Host Deploying SPCHOL300 for Bugs List...
stsadm -o addsolution -filename $scriptPath\spchol300-ex1.wsp
stsadm -o deploysolution -name spchol300-ex1.wsp -local -allowgacdeployment

Write-Host Activating SPCHOL300 feature....
stsadm -o activatefeature -name Bugs_Feature1 -url http://intranet.contoso.com/ -force

[void][System.reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint")
$bugsData=@("Bug1,Bug1,Writing more sample code,Kim Abercrombie",
            "Bug2,Bug2,Project Two,Joe Healy",
            "Bug3,Bug3,Building more developer tools,Bjorn Rettig",
            "Bug4,Bug4,Writing developer articles,Andy Ruth",
            "Bug5,Bug5,Writing more sample code,Kevin Kelly",
            "Bug6,Bug6,Answering forums questions,Paul West")

$site = new-object Microsoft.SharePoint.SPSite("http://intranet.contoso.com")

$web = $site.RootWeb
Write-Host Opened $web.Title

$bugsList=$web.Lists["Bugs"];

Write-Host Opened $bugsList.Title list...

Write-Host Removing ItemAdding, ItemUpdating and ItemDeleting event receivers on Bugs list...

for($evIdx = 0; $evIdx -lt $bugsList.EventReceivers.Count; $evIdx++)   
{  
            # get a reference to the Event Receiver   
            [Microsoft.SharePoint.SPEventReceiverDefinition] $er = $bugsList.EventReceivers[$evIdx]  
            # if it's a type we care about ...   
            if ( $er.Type -eq 'ItemDeleting' -or $er.Type -eq 'ItemUpdating' -or $er.Type -eq 'ItemAdding')   
            {   
                [string] $erType = $bugsList.EventReceivers[$evIdx].Type  
                # get rid of it   
                $bugsList.EventReceivers[$evIdx].Delete()   
                Write-Host "Removed an $erType Event Receiver from $listTitle"  
                $found = $true  
            }  
            # if we removed any of the specified Event Receivers from the list, update the list   
            if ($found)   
            {   
                $bugsList.Update()   
            }   
}   

Write-Host Deleting any existing items...

$list=$web.Lists["Bugs"];
$items = $list.Items;	
$itemCount = $items.Count;
Write-Host "$itemCount items found in $ListName."
for ($i=$items.Count -1; $i -ge 0; $i -= 1) 
{
	$items.Delete($i);
	$percentComplete = (($itemCount-$i)/$itemCount)* 100
	Write-Progress -Activity "Deleteing item $i in $ListName" -PercentComplete $percentComplete -Status "Please wait."
}

Write-Host Adding items to bugs list...
foreach($bug in $bugsData)
{
    $bugData=$bug.Split(",")
    $newBug=$list.items.Add()
    
    $newBug["Title"]=$bugData[0];
    $newBug["Description"]=$bugData[1];
    $newBug["Project"]=$bugData[2];
    $newBug["Assigned To"]=$bugData[3];
          
    $newBug.Update()
    
    Write-Host Bug $bugData[0] added...
}

$web.Dispose()
$site.Dispose()
             
             