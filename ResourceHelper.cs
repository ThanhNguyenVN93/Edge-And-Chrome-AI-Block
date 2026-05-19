using System.Drawing;
using System.Reflection;

namespace frm_edAI_chrAI_block
{
    internal static class ResourceHelper
    {
        // Loads an image embedded as EmbeddedResource named "<filename>" in this assembly.
        // Resource name format: <RootNamespace>.<filename>
        internal static Image LoadImage(string filename)
        {
            var asm = Assembly.GetExecutingAssembly();
            string resourceName = "frm_edAI_chrAI_block." + filename;
            using (var stream = asm.GetManifestResourceStream(resourceName))
            {
                if (stream == null) return null;
                return Image.FromStream(stream);
            }
        }
    }
}
