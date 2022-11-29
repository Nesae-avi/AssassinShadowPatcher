namespace AssassinShadowPatcher
{
    internal class BinaryIO
    {
        public static bool ReadFile(string filePath, out byte[] data)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or empty.", nameof(filePath));
            }

            data = new byte[4096];

            using (BinaryReader reader = new(File.Open(filePath, FileMode.Open)))
            {
                using (MemoryStream ms = new())
                {
                    int cnt;
                    byte[] buffer = new byte[4096];

                    while ((cnt = reader.Read(buffer, 0, buffer.Length)) != 0)
                        ms.Write(buffer, 0, cnt);

                    data = ms.ToArray();
                }
            }

            return true;
        }

        public static bool WriteFile(string filePath, byte[] data)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or empty.", nameof(filePath));
            }

            using (BinaryWriter writer = new(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(data);
            }

            return true;
        }
    }
}
