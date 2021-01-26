# Copyright (c) Microsoft. All rights reserved.
# Licensed under the MIT license. See LICENSE file in the project root for full license information.

[string]$target
[string]$adminUserName

$domainName = $PtfProp_Common_DomainName
$sutComputerName = $PtfProp_Common_SutComputerName
$dcName = $PtfProp_Common_DCServerComputerName

$isDomainEnv = (-not [string]::IsNullOrEmpty($domainName)) -and ($domainName -ne $sutComputerName)
$remoteComputerName = if ($isDomainEnv) {
    $dcName
}
else {
    $target
}

$commandForDomain = {
    param(
        [string]$target
    )

    $domainFqn = "DC=" + $target.Replace(".", ",DC=")
    $usersFqn = "CN=Users,$domainFqn"

    [array]$domainUsers = Get-ADUser -Filter "*" -SearchBase $usersFqn 

    return $domainUsers
}

$commandForLocalComputer = {
    return @(Get-LocalUser)
}

try {
    [array]$results = if ($isDomainEnv) {
        Invoke-Command -HostName $remoteComputerName -UserName "$target\$adminUserName" -ScriptBlock $commandForDomain -ArgumentList @($target)
    }
    else {
        Invoke-Command -HostName $remoteComputerName -UserName "$adminUserName" -ScriptBlock $commandForLocalComputer
    }
}
catch {
    Get-Error
}

$users = @()
foreach ($result in $results) {
    $user = @{
        Name = $result.Name
        Sid  = $result.SID.Value
    }
    $users += $user
}

if ($users.Length -eq 0) {
    return "[]"
}
else {
    return ($users | ConvertTo-Json)
}