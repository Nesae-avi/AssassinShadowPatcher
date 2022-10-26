namespace AssassinShadowPatcher
{
    internal class Patcher
    {
        private static int ScanData(byte[] data, byte[] scanArray)
        {
            // This loop goes over data.
            for (int i = 0; i < data.Length; i++)
            {
                bool found = true;

                // This loop goes over scanArray.
                for (int j = 0; j < scanArray.Length; j++)
                {
                    if (data[i + j] != scanArray[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    return i;
            }

            return -1;
        }

        private static byte[] Patch(int patchLocation, int length, byte[] inputData, byte[] patchData)
        {
            for (int i = 0; i < length; i++)
                inputData[patchLocation + i] = patchData[i];

            return inputData;
        }

        public static byte[]? PatchACRSP(byte[] inputData)
        {
            var scanLocOne = ScanData(inputData, new byte[] { 0x3B, 0x7E, 0x6C, 0x77, 0x0D });
            var scanLocTwo = ScanData(inputData, new byte[] { 0x89, 0x7E, 0x6C, 0x5B, 0x5F });

            if (scanLocOne == -1 || scanLocTwo == -1)
                return null;

            byte[] replaceCodeOne = new byte[] { 0xC7, 0x46, 0x6C, 0x00, 0x10, 0x00, 0x00, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            byte[] replaceCodeTwo = new byte[] { 0x90, 0x90, 0x90 };

            var patchedOne = Patch(scanLocOne, 0x12, inputData, replaceCodeOne);
            var patchedTwo = Patch(scanLocTwo, 0x3, patchedOne, replaceCodeTwo);

            return patchedTwo;
        }
    }
}
