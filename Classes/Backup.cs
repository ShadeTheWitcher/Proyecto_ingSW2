using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller_AdminShop.Classes.Models;


namespace Proyecto_Taller_AdminShop.Classes
{

public class BackUpAdminShop
{
    private static Admin_shopEntities db = new Admin_shopEntities();

    public BackUpAdminShop()
	{

	}

        public bool Backup(string database, string path)
{
    try
    {
        string connectionString = db.Database.Connection.ConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string backupFileName = $"{database}_{DateTime.Now.ToString("yyyyMMdd")}.bak";
            string backupFilePath = Path.Combine(path, backupFileName);

            // Validaciones adicionales
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (File.Exists(backupFilePath))
                throw new Exception($"Ya existe un archivo de respaldo con el nombre {backupFileName}");

            string query = $"BACKUP DATABASE {database} TO DISK = '{backupFilePath}'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        return true;
    }
    catch (Exception e)
    {
        // Considera registrar la excepción completa para un diagnóstico más detallado
        throw new Exception($"Error al realizar el respaldo de la base de datos: {e.Message}", e);
    }
}


        public string GetUbication(bool getFile)
        {
            try
            {
                if (!getFile)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.ShowDialog();
                    return folderBrowserDialog.SelectedPath;
                }

                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "Backup files (*.bak)|*.bak",
                    Title = "Seleccionar archivo",
                    RestoreDirectory = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Multiselect = false,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK) return openFileDialog.FileName;
                return string.Empty;
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener la ubicación");
            }
        }

        public bool Restore(string database, string backupFilePath)
        {
            try
            {
                string connectionString = db.Database.Connection.ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Poner la base de datos en modo de usuario único y realizar la restauración
                    string useMaster = "USE master";
                    SqlCommand useMasterCommand = new SqlCommand(useMaster, connection);
                    useMasterCommand.ExecuteNonQuery();

                    string alterDb = $"ALTER DATABASE {database} SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    SqlCommand alterDbCommand = new SqlCommand(alterDb, connection);
                    alterDbCommand.ExecuteNonQuery();

                    string restore = $"RESTORE DATABASE {database} FROM DISK = '{backupFilePath}' WITH REPLACE";
                    SqlCommand restoreCommand = new SqlCommand(restore, connection);
                    restoreCommand.ExecuteNonQuery();

                    string multiUser = $"ALTER DATABASE {database} SET MULTI_USER";
                    SqlCommand multiUserCommand = new SqlCommand(multiUser, connection);
                    multiUserCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception e)
            {
                // Considera registrar la excepción completa para un diagnóstico más detallado
                MessageBox.Show($"Error al restaurar la base de datos: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
