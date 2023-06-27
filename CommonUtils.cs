using System.Text;
using System.Windows.Forms;
using Environment = System.Environment;

namespace ExamifyClassLibrary
{
    public static class CommonUtils
    {
        /// <summary>
        /// Exports the data from a DataGridView to a text file on the user's desktop.
        /// </summary>
        /// <param name="dataGridView">The DataGridView containing the data to export.</param>
        public static void ExportDataGridViewToTextFile(DataGridView dataGridView)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Append column headers
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    sb.Append(column.HeaderText);
                    sb.Append("\t");
                }
                sb.AppendLine();

                // Append row data
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value);
                        sb.Append("\t");
                    }
                    sb.AppendLine();
                }

                // Save data to file on the user's desktop
                string desktopPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExportedData.txt");
                File.WriteAllText(desktopPath, sb.ToString());

                MessageBox.Show("Data exported successfully! File saved on the desktop.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        }
    }
}
