using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace Ralph.Plugin._7._0
{
  [ActionHandler("Ralph.Plugin.7.0.About")]
  public class AboutAction : IActionHandler
  {
    public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
    {
      // return true or false to enable/disable this action
      return true;
    }

    public void Execute(IDataContext context, DelegateExecute nextExecute)
    {
      MessageBox.Show(
        "AgentRalphPlugin\nJosh Buedel\n\nA code clone tool",
        "About AgentRalphPlugin",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }
  }
}