namespace CRUD_Oficina_V2
{
    public static class FileHandler
    {
        public static List<string[]> ReadData(string filePath)
        {
            List<string[]> data = new List<string[]>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] rowData = line.Split(',');
                        data.Add(rowData);
                    }
                }
            }

            return data;
        }

        public static void SaveData(List<string[]> data, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var rowData in data)
                {
                    writer.WriteLine(string.Join(",", rowData));
                }
            }
        }
    }
}
