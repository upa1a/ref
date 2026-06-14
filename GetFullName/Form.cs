using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFullName
{
    public partial class GetFullname : Form
    {
        public GetFullname()
        {
            InitializeComponent();
        }

        private async void btnGetFullname_Click(object sender, EventArgs e)
        {
            TSHelper helper = new TSHelper();

            try
            {
                string name = await helper.GetFullNameAsync();

                tbFullname.Text = name;

                bool isValid = Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ\s]+$");

                if (!isValid)
                {
                    rtbMessage.Text = "Полученное ФИО содержит недопустимые символы";
                }
                else
                {
                    rtbMessage.Text = "Успешно получено";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "500")
                {
                    rtbMessage.Text = "Ошибка на стороне сервера (500). Обратитесь к главному эксперту";
                }
                else
                {
                    rtbMessage.Text = "Не удалось получить данные из внешнего сервиса.\r\nПроверьте, запущен ли эмулятор TransferSimulator";
                }
            }
        }
    }
}
