using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_EasierIdentiers
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_EasierIdentiersExtension : IVsixPluginExtension { }
}