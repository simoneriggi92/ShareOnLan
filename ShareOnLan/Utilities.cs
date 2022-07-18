using System;
using System.IO;

namespace ShareOnLan
{
    public static class Utilities
    {
        /// <summary>
        /// Se il file esiste già, cambia il nome aggiungendo un numero
        /// file.exe -> file(1).exe
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>Il nome del file aggiornato</returns>
        public static string CheckIfFileExists(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            string pathName = Path.GetDirectoryName(filePath);
            string fileNameOnly = Path.Combine(pathName, Path.GetFileNameWithoutExtension(filePath));
            int i = 0;
            // If the file exists, keep trying until it doesn't
            while (File.Exists(filePath))
            {
                i += 1;
                filePath = String.Format("{0}({1}){2}", fileNameOnly, i, extension);
            }
            return filePath;
        }

        /// <summary>
        /// Converte i byte in megabyte
        /// </summary>
        /// <param name="bytes">Byte da convertire</param>
        /// <returns>Valore convertito in megabyte</returns>
        public static string ConvertBytesToMegabytes(long bytes)
        {
            double megabytes = (bytes / 1024f) / 1024f;
            return megabytes.ToString("F2");
        }

        /// <summary>
        /// Converte i byte in gigabyte
        /// </summary>
        /// <param name="bytes">Byte da convertire</param>
        /// <returns>Valore convertito in gigabyte/returns>
        public static string ConvertBytesToGigabytes(long bytes)
        {
            double gigabytes = ((bytes / 1024f) / 1024f) / 1024f;
            return gigabytes.ToString("F2");
        }

        /// <summary>
        /// Calcola l'unità di misura corretta (byte, MB, GB) in base alla dimensione del file
        /// e lo arrotonda opportunamente 
        /// </summary>
        /// <param name="filesize">Dimensione del file</param>
        /// <returns>Dimensione del file + unità di misura</returns>
        public static string GetFileSizeWithUnit(long filesize)
        {
            string fileSizeByte = String.Empty;
            string fileSizeWithUnit = String.Empty;
            if (filesize >= 1024 && filesize < Math.Pow(1024, 3))
            {
                fileSizeByte = ConvertBytesToMegabytes(filesize);
                fileSizeWithUnit = fileSizeByte + " MB";
            }
            else if (filesize < 1024)
            {
                fileSizeWithUnit = filesize.ToString("N0") + " byte";
            }
            else
            {
                if (filesize >= Math.Pow(1024, 3))
                {
                    fileSizeWithUnit = ConvertBytesToGigabytes(filesize) + " GB";
                }
            }
            return fileSizeWithUnit;
        }

        public static void CleanTempfile(bool isDirectory, String path_file)
        {
            if (File.Exists(path_file) && isDirectory)
            {
                File.Delete(path_file);
            }
        }
    }
}
