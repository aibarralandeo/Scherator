using System.IO;

namespace Scherator.Utils.IO
{
    public static class DiskUtilities
    {
        public static bool PathExists(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
                return Directory.Exists(path);
            else
                return File.Exists(path);
        }
    }
}
