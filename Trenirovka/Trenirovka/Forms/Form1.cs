using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trenirovka.Forms;
using Trenirovka.Models;

namespace Trenirovka
{
    public partial class Form1 : Form
    {
        private TrenirovkaEntities _entities;
        private string captchaText;
        public Form1()
        {
            InitializeComponent();
            _entities = new TrenirovkaEntities();
            GenerateCaptcha();
        }
        private void GenerateCaptcha()
        {
            captchaText = Guid.NewGuid().ToString().Split('-')[0];
            captcha.Text = captchaText;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (capBox.Text == captchaText)
            {
                Agents currentUser = _entities.Agents.FirstOrDefault(x => x.Id_agents.ToString() == Loginbox.Text && x.Gmail == Passwordbox.Text);
                if (currentUser != default)
                {
                    Loginbox.Text = string.Empty;
                    Passwordbox.Text = string.Empty;
                    Hide();

                    switch (currentUser.Role_id)
                    {
                        case 1:
                            {
                                Adminform moderForm = new Adminform();
                                moderForm.Show();
                            }
                            break;
                        case 2:
                            {
                                Usersform orgForm = new Usersform();
                                orgForm.Show();
                            }
                            break;
                        case 3:
                            {
                                Sotrform uchastForm = new Sotrform();
                                uchastForm.Show();
                            }
                            break;
                    }
                }
                else
                {
                    Oshibka.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Заполните капчу!");
            }
        }
    }
    
}

