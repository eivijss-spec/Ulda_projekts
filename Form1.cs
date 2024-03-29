﻿using System;
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
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Ulda_problemas
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        // vērtības kuras nemainās
        int darba_samaksa = 15;
        int PVN = 21;


        private void button1_Click(object sender, EventArgs e)
        {   //Pārveido vēlējumu stringu uz int
            string varda_ga = tb_veltijums.Text;
            double gar = varda_ga.Length;

            // Pārbauda vai visas nepieciešamās vērtības ir 
            if (
                double.TryParse(tb_platums.Text, out double platums) &&
                double.TryParse(tb_garums.Text, out double garums) &&
                double.TryParse(tb_augstums.Text, out double augstums) &&
                double.TryParse(tb_cena.Text, out double materiala_cena))
            {
                //  saksaita characters tb_veltijums un reizina ar 1.2
                string inputText = tb_veltijums.Text;
                double charCount = inputText.Length;
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
                rtb_reikins.Text = "Kartupelis esi? Ievadi pareizi!";
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
                MessageBox.Show("saglabāts failā");
            }
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
                        // Pievieno dataubazei notiektas kolonas
                        sqlite_cmd.CommandText = "INSERT INTO Ulda(Vards, Velejums, platums, augstums, Garums, cena) " +
                                                 "VALUES(@Vards, @Velejums, @platums, @augstums, @Garums, @cena);";

                        // pievieno tb vertibas datubazes kolonam
                        sqlite_cmd.Parameters.AddWithValue("@Vards", tb_vards.Text);
                        sqlite_cmd.Parameters.AddWithValue("@Velejums", tb_veltijums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@platums", tb_platums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@augstums", tb_augstums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@Garums", tb_garums.Text);
                        sqlite_cmd.Parameters.AddWithValue("@cena", tb_cena.Text);

                        // šaujam
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("Saglabāts datubāzē");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lūdzu ievadiet nosaukumu");
            }
        }
        // izveido savienojumu ar dau bāzi
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection reikin = new SQLiteConnection("Data Source=reikin.db; Version=3; New=true; Compress=True;");
            return reikin;
        }

        // izveido savienojumu ar dau bāzi
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

        //dzēst no datubāzes
        private void Dzest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dz_id.Text, out int id))
            {
                {


                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConeection();

                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "DELETE FROM Ulda WHERE ID=" + dz_id.Text + ";";
                    sqlite_cmd.ExecuteNonQuery();
                    dz_id.Clear();




                    MessageBox.Show("Izdzēsts no datubāzes");

                }
            }
            else
            { // izvada ziņojumu ja ir nepareiza vertība ievadīta
                MessageBox.Show("Ievadiet id ko vēlaties dzēst");
            }
        }
//Izvad atutu bazi uz ekrāna un atjaunina to
        private void metroSetEllipse1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Ulda";

            DataTable sTable;
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            using (sTable = new DataTable())
            {
                sqlda.Fill(sTable);
                dataGridView1.DataSource = sTable;
            }
            sqlite_conn.Close();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dz_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      // cita x poga
        private void X_But_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {

        }

        private void hide_Click(object sender, EventArgs e)
        {

        }
        // x poga
        private void ara_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
            



      