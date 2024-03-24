using System.Management.Automation;
using PSTools.Containers;

namespace PSTools
{
    [Cmdlet(VerbsCommon.Get, "PendigReboot")]
    [OutputType(typeof(PendigReboot))]
    public class GetPendigRebootCmdlet: Cmdlet
    {
        [Parameter(Position=1,ValueFromPipelineByPropertyName = true)]
        public string ComputerName { get; set; }
    }
}
namespace PSTools.Containers
{
    public class PendigReboot
    {
        public string ComputerName { get; set; }
        public bool CBServicing { get; set; }
        public bool WindowsUpdate { get; set; }
        public bool CCMClientSDK { get; set; }
        public bool PendComputerRename { get; set; }
        public bool PendFileRename { get; set; }
        public bool PendFileRenVal { get; set; }
        public bool RebootPending { get; set; }
    }
}