# GetGreeting

Ein Hallo Welt-Programm zum Erstellen von binären Cmdlets für die PowerShell in C#.

Das Cmdlet kann in .NET Core kompliliert werden. Zum Erstellen des Cmdlets wird das Template PSModule verwendet:

```
dotnet new -i Microsoft.PowerShell.Standard.Module.Template
dotnet new psmodule --name Greetings
cd Greetings
```

Die Datei neu erstelle Beispieldatei TestSampleCmdletCommand.cs wird durch Greetings.cs ersetzt. Anschließend wird das Cmdlet erstellt und kann in die PowerShell importiert werden:

```
dotnet build
Import-Module bin\Debug\netstandard2.0\Greetings.dll
```

Und es kann ausgeführt werden:

```
Get-Greeting -Name Welt
Write-Output "Welt" | Get-Greeting | Select-String -Pattern "Hallo"
```
