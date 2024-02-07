using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Ulda_problemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tb_cena_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_platums_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_garums_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_veltijums_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_vards_TextChanged(object sender, EventArgs e)
        {

        }
        private void rtb_reikins_TextChanged(object sender, EventArgs e)
        {

        }







        int darba_samaksa = 15;
        int PVN = 21;
        private void button1_Click(object sender, EventArgs e)
        {   //Pārveido vēlējumu stringu uz int
            string varda_ga = tb_veltijums.Text;
            int gar = varda_ga.Length;

            // Pārbauda vai visas nepieciešamās vērtības ir 
            if (
                int.TryParse(tb_platums.Text, out int platums) &&
                int.TryParse(tb_garums.Text, out int garums) &&
                int.TryParse(tb_augstums.Text, out int augstums) &&
                int.TryParse(tb_cena.Text, out int materiala_cena))
            {
                //  saksaita characters tb_veltijums un reizina ar 1.2
                string inputText = tb_veltijums.Text;
                int charCount = inputText.Length;
                double multipliedCount = charCount * 1.2;

                // veic matemātiku
                double produkta_cena = (gar * 1.2) + ((platums / 100) * (augstums / 100) * (garums / 100)) / 3 * materiala_cena;
                double PVN_summa = (produkta_cena + darba_samaksa) * PVN / 100;
                double rekina_summa = produkta_cena + darba_samaksa + PVN_summa;

                // Parāda to RichTextBox
                rtb_reikins.Text = $"Produkta cena: {produkta_cena:C}\n" +
                                   $"PVN summa: {PVN_summa:C}\n" +
                                   $"Rekina summa: {rekina_summa:C}\n";

















            }
            else
            {
                // izvada tekstu ja ir kaut kas nepareiz
                rtb_reikins.Text = "lohs tu ievadi pareizi.";
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                StreamWriter a = new StreamWriter("Reikins.txt");

                //Izveidojam jaunu mapi ar failu, kur saglabāsies informācija

                a.WriteLine(label1.Text + " " + tb_vards.Text);
                a.WriteLine(label2.Text + " " + tb_veltijums.Text);
                a.WriteLine(label3.Text + " " + tb_platums.Text);
                a.WriteLine(label4.Text + " " + tb_garums.Text);
                a.WriteLine(label5.Text + " " + tb_augstums.Text);
                a.WriteLine(label6.Text + " " + tb_cena.Text);

                //Ierakstītie dati programmā pēc pogas nospiešanas saglabāsies failā "lietotajainfo"


                a.Close();






            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_vards.Text != "")
            {
                using (SQLiteConnection sqlite_conn = CreateConnection())
                {
                    sqlite_conn.Open();

                    using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        // Use parameters to prevent SQL injection
                        sqlite_cmd.CommandText = "INSERT INTO Ulda(Vards, Velejums, platums, augstums, Garums, cena) " +
                                                 "VALUES(@Vards, @Velejums, @platums, @augstums, @Garums, @cena);";

                        // Add parameters to the command
                        sqlite_cmd.Parameters.AddWithValue("@Vards", tb_vards.Text);
                        sqlite_cmd.Parameters.AddWithValue("@Velejums", tb_veltijums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@platums", tb_platums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@augstums", tb_augstums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@Garums", tb_garums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@cena", tb_cena.Text);

                        // Execute the command
                        sqlite_cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lūdzu ievadiet nosaukumu");
            }
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection reikin = new SQLiteConnection("Data Source=reikin.db; Version=3; New=true; Compress=True;");
            return reikin;
        }







        static SQLiteConnection CreateConeection()
        {
            SQLiteConnection reikin;
            reikin = new SQLiteConnection("Data Source=reikin.db; Version = 3; New = true; Compress = True;");
            try
            {
                reikin.Open();

            }
            catch
            {

            }
            return reikin;
        }

        private void Dzest_Click(object sender, EventArgs e)
        {

            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConeection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM Ulda WHERE ID=" + dz_id.Text + ";";
                sqlite_cmd.ExecuteNonQuery();
                dz_id.Clear();

            }
        }

    }
}
            



      