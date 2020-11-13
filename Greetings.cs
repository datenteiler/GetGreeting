using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Greetings
{
    [Cmdlet(VerbsCommon.Get,"Greeting")]
    public class GetGreetingCommand : PSCmdlet
    {
        // Declare the parameters for the cmdlet.
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        // Overide the ProcessRecord method to process
        // the supplied user name and write out a 
        // greeting to the user by calling the WriteObject
        // method.
        protected override void ProcessRecord()
        {
          WriteObject("Hallo " + Name + "!");
        }
    }
}
