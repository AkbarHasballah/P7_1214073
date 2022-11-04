using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P7_1214073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 272);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnim_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            tbnama.Clear();
            tbnim.Clear();
            tbalamat.Clear();
            rblaki.Checked = false;
            rbcewe.Checked = false;
            cbstudi.Text = null;
            tbthn.Clear();
            tbsemester.Clear();
            cbjarkom.Checked= false;
            cbp1.Checked = false;
            cbp2.Checked = false;
            cbp3.Checked = false;
            cbp4.Checked = false;
            cbp5.Checked = false;
            cbp6.Checked = false;
            cbp7.Checked = false;
            cblog.Checked = false;
            cbmtk.Checked = false;
            cbsio.Checked = false;
            rbk06.Checked = false;
            rbk10.Checked = false;
            rb14.Checked = false;

            this.Size = new Size(812, 272);

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string jl = null;
            if (rblaki.Checked)
            {
                jl = rblaki.Text;
            }
            else
            {
                jl = rblaki.Text;
            }
            string tahun = null;
            if (rbk06.Checked)
            {
                tahun = rbk06.Text;
            }
            else if(rbk10.Checked)
            {
               tahun =rbk10.Text;
            }
        string matkul= "";
            if (cbmtk.Checked)
            {
                matkul += cbmtk.Text + " ";
            }
            if (cbp1.Checked)
            {
                matkul+= cbp1.Text + " ";
            }
            if (cbp2.Checked)
            {
                matkul+= cbp2.Text + " ";
            }
            if (cbp3.Checked)
            {
                matkul+= cbp3.Text + " ";
            }
            if (cbp4.Checked)
            {
                matkul+= cbp4.Text + " ";
            }
            if (cbp5.Checked)
            {
                matkul+= cbp5.Text + " ";
            }
            if (cbp6.Checked)
            {
                matkul+= cbp6.Text + " ";
            }
            if (cblog.Checked)
            {
                matkul+= cblog.Text + " ";
            }
            if (cbjarkom.Checked)
            {
                matkul+= cbjarkom.Text + " ";
            }
            if (cbsio.Checked)
            {
                matkul+= cbsio.Text + " ";
            }
            MessageBox.Show
                ("Nama : " + tbnama.Text +
                    "\nNIM: " + tbnim.Text +
                    "\nJenis Kelamin: " + jl +
                    "\nAlamat: " + tbalamat.Text +
                    "\nProgram Studi: " + cbstudi.Text +
                    "\nTahun Akademik: " + tbthn.Text +
                    "\nSemester: " + tbsemester.Text +
                    "\n" + "\n" +
                    "\nTahun Akademik: " + tahun +
                    "\nMata kuliah: " + matkul, " Terimakasih data anda sudah di rekam", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbnim.Text != "")
            {
                if (tbnama.Text != "")
                {
                    if (rblaki.Checked)
                    {
                        if (tbalamat.Text != "")
                        {
                            if (cbstudi.Text != "")
                            {
                                if (tbthn.Text != "")
                                {
                                    if (tbsemester.Text != "")
                                    {
                                        MessageBox.Show("Sudah Terdata",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(816, 533);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Isi semester!",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Tahun akademik harus di isi",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Harus memilih Progam studi",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Alamat Harus di isi",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (rbcewe.Checked) ;
                    else
                    {
                        MessageBox.Show("jenis kelamin Harus di isi",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nama Harus di isi",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nim Harus di isi",
                    "informasi data calon mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbthn_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbthn_TextChanged(object sender, EventArgs e)
        {
            if(tbthn.Text != "")
            {
                epWar.SetError(tbthn, " Harus mengisi");
            }
            else
            {
                if (Regex.IsMatch (tbthn.Text, @"^\d{4}/\d{4}$"))
                {
                    epEr.SetError(tbthn, "");
                }
                else
                {
                    epEr.SetError(tbthn, " Harus mengisi sesuai ketentuan");
                }
            }
        }

        private void tbsemester_TextChanged(object sender, EventArgs e)
        {
            if ((tbsemester.Text).All(char.IsNumber))
            {
                epcor.SetError(tbsemester, "");
                epWar.SetError(tbsemester, "");
                epEr.SetError(tbsemester, "");
            }
            else
            {
                epEr.SetError(tbsemester, "Inputan hanya boleh Angka!");
            }
        }

        private void rbk06_CheckedChanged(object sender, EventArgs e)
        {
            if (rbk06.Checked)
            {
                cbmtk.Enabled = true; cbmtk.Checked = false;
                cbp1.Enabled = true; cbmtk.Checked = false;
                cbp2.Enabled = true; cbmtk.Checked = false;
                cbp3.Enabled = true; cbmtk.Checked = false;
                cbp4.Enabled = true; cbmtk.Checked = false;
                cbp5.Enabled = true; cbmtk.Checked = false;
                cbp6.Enabled = true; cbmtk.Checked = false;
                cbp7.Enabled = true; cbmtk.Checked = false;
                cblog.Enabled = false; cbmtk.Checked = false;
                cbjarkom.Enabled = true; cbmtk.Checked = false;
                cbsio.Enabled = true; cbmtk.Checked = false;
                cbmenej.Enabled = false; cbmtk.Checked = false;
            }
        }

        private void gbkurikulum_Enter(object sender, EventArgs e)
        {
            
        }

        private void rbk10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbk10.Checked)
            {
                cbmtk.Enabled = false; cbmtk.Checked = false;
                cbp1.Enabled = true; cbmtk.Checked = false;
                cbp2.Enabled = true; cbmtk.Checked = false;
                cbp3.Enabled = true; cbmtk.Checked = false;
                cbp4.Enabled = true; cbmtk.Checked = false;
                cbp5.Enabled = true; cbmtk.Checked = false;
                cbp6.Enabled = true; cbmtk.Checked = false;
                cbp7.Enabled = true; cbmtk.Checked = false;
                cblog.Enabled = false; cbmtk.Checked = false;
                cbjarkom.Enabled = true; cbmtk.Checked = false;
                cbsio.Enabled = true; cbmtk.Checked = false;
                cbmenej.Enabled = true; cbmtk.Checked = false;
            }
        }

        private void rb14_CheckedChanged(object sender, EventArgs e)
        {
            if (rb14.Checked)
            {
                cbmtk.Enabled = false; cbmtk.Checked = false;
                cbp1.Enabled = true; cbmtk.Checked = false;
                cbp2.Enabled = true; cbmtk.Checked = false;
                cbp3.Enabled = true; cbmtk.Checked = false;
                cbp4.Enabled = true; cbmtk.Checked = false;
                cbp5.Enabled = true; cbmtk.Checked = false;
                cbp6.Enabled = true; cbmtk.Checked = false;
                cbp7.Enabled = true; cbmtk.Checked = false;
                cblog.Enabled = true; cbmtk.Checked = false;
                cbjarkom.Enabled = true; cbmtk.Checked = false;
                cbsio.Enabled = true; cbmtk.Checked = false;
                cbmenej.Enabled = false; cbmtk.Checked = false;
            }
        }
    }
    }
