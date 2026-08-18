using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveBROGym
{
    public partial class formActiveBRO : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ActiveBRO.accdb;Jet OLEDB:Database Password=studiodata;";
        public formActiveBRO()
        {
            InitializeComponent();
            this.dateTime.Value = DateTime.Now;
        }
        private string serial = "2012E3F1260A";
        private void hardSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                //string mo = "";
                string se = "";
                foreach (ManagementObject disk in searcher.Get())
                {
                    //mo = disk["Model"].ToString();
                    se = disk["SerialNumber"].ToString();
                }
                if (serial != se)
                {
                    MessageBox.Show("هذه عملية غير شرعية لتشغيل البرنامج! من فضلك احترم حقوق الملكية، اشتري البرنامج أو توقف عن تشغيله", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void formActiveBRO_Load(object sender, EventArgs e)
        {
            try
            {
                CreateAllDataView();
                hardSerialNumber();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SavePhotosData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string insertQuery = "INSERT INTO Active (CustomerName, CustomerPhone, CustomerAddress, CustomerDate, CustomerPrice, CustomerNote) VALUES (?, ?, ?, ?, ?, ?);";
                    OleDbCommand command = new OleDbCommand(insertQuery, connection);
                    // إضافة القيم إلى استعلام الإدخال من TextBox
                    command.Parameters.AddWithValue("@CustomerName", textCustName.Text);
                    command.Parameters.AddWithValue("@CustomerPhone", textCustPhone.Text);
                    command.Parameters.AddWithValue("@CustomerAddress", textCustAddress.Text);
                    command.Parameters.AddWithValue("@CustomerDate", dateTime.Value);
                    command.Parameters.AddWithValue("@CustomerPrice", textCustPrice.Text);
                    command.Parameters.AddWithValue("@CustomerNote", textCustNote.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("تم حفظ بيانات المشترك بنجاح", "تأكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void UpdatePhotoData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string updateQuery = "UPDATE Active SET CustomerName = ?, CustomerPhone = ?, CustomerAddress = ?, CustomerDate = ?, CustomerPrice = ?, CustomerNote = ? WHERE CustomerID = ?";
                    OleDbCommand command = new OleDbCommand(updateQuery, connection);
                    // إضافة القيم إلى استعلام التعديل من TextBox
                    command.Parameters.AddWithValue("@CustomerName", textCustName.Text);
                    command.Parameters.AddWithValue("@CustomerPhone", textCustPhone.Text);
                    command.Parameters.AddWithValue("@CustomerAddress", textCustAddress.Text);
                    command.Parameters.AddWithValue("@CustomerDate", dateTime.Value);
                    command.Parameters.AddWithValue("@CustomerPrice", Convert.ToInt32(textCustPrice.Text));
                    command.Parameters.AddWithValue("@CustomerNote", textCustNote.Text);
                    command.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(textCustID.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("تم تعديل بيانات المشترك بنجاح", "تأكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DeletePhotoData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string deleteQuery = "DELETE FROM Active WHERE CustomerID = ?;";
                    OleDbCommand command = new OleDbCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(textCustID.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("تم حذف بيانات المشترك بنجاح", "تأكيد الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textCustName.Text) || string.IsNullOrWhiteSpace(textCustPhone.Text) || string.IsNullOrWhiteSpace(textCustNote.Text) || string.IsNullOrWhiteSpace(textCustAddress.Text) || string.IsNullOrWhiteSpace(textCustPrice.Text))
                {
                    MessageBox.Show("الرجاء إدخال قيمة في الحقل الفارغ", "تحذير");
                }
                else
                {
                    SavePhotosData();
                    CreateAllDataView();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textCustName.Text) && !string.IsNullOrEmpty(textCustID.Text) && !string.IsNullOrEmpty(textCustNote.Text) && !string.IsNullOrEmpty(textCustPhone.Text) && !string.IsNullOrEmpty(textCustPrice.Text) && !string.IsNullOrEmpty(textCustAddress.Text))
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد تعديل بيانات المشترك؟", "تأكيد التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        UpdatePhotoData();
                        CreateAllDataView();
                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء عملية التعديل");
                    }
                }
                else
                {
                    //TextBox فارغ
                    MessageBox.Show("لا يمكن ترك بيانات المشترك فارغة، من فضلك أكمل إدخال البيانات", "تلميح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textCustID.Text))
                {
                    int customerID = int.Parse(textCustID.Text);
                    // عرض رسالة تأكيد للمستخدم
                    DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا المشترك؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeletePhotoData();
                        CreateAllDataView();
                    }
                    else
                    {
                        MessageBox.Show("تم إلغاء عملية الحذف");
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن ترك خانة رقم المشترك فارغة، من فضلك أكمل إدخال البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataView.SelectedRows[0];
                    textCustID.Text = row.Cells["CustomerID"].Value?.ToString();
                    textCustName.Text = row.Cells["CustomerName"].Value?.ToString();
                    textCustPhone.Text = row.Cells["CustomerPhone"].Value?.ToString();
                    textCustAddress.Text = row.Cells["CustomerAddress"].Value?.ToString();
                    dateTime.Text = row.Cells["CustomerDate"].Value?.ToString();
                    textCustPrice.Text = row.Cells["CustomerPrice"].Value?.ToString();
                    textCustNote.Text = row.Cells["CustomerNote"].Value?.ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void connctionQuery(DataGridView dataView, string txtGuary)
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ActiveBRO.accdb;Jet OLEDB:Database Password=studiodata;";
                OleDbConnection connection = new OleDbConnection(connectionString);
                string TabelQuery = txtGuary;
                OleDbCommand command = new OleDbCommand(TabelQuery, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataView.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void CreateAllDataView()
        {
            try
            {
                connctionQuery(dataView, "SELECT CustomerID, CustomerName, CustomerPhone, CustomerAddress, CustomerDate, CustomerPrice, CustomerNote FROM Active;");
                dataView.Columns[0].HeaderText = "رقم المشترك";
                dataView.Columns[1].HeaderText = "اسم المشترك";
                dataView.Columns[2].HeaderText = "تليفون المشترك";
                dataView.Columns[3].HeaderText = "عنوان المشترك";
                dataView.Columns[4].HeaderText = "تاريخ الاشتراك";
                dataView.Columns[5].HeaderText = "سعر الاشتراك";
                dataView.Columns[6].HeaderText = "الملاحظات";
                dataView.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAllDataView();
                textCustID.Text = "";
                textCustName.Text = "";
                textCustPhone.Text = "";
                textCustAddress.Text = "";
                textCustNote.Text = "";
                textCustPrice.Text = "";
                this.dateTime.Value = DateTime.Now;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textCustName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "SELECT CustomerID, CustomerName, CustomerPhone, CustomerAddress, CustomerDate, CustomerPrice, CustomerNote FROM Active WHERE CustomerName LIKE ?";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@CustomerName", "%" + textCustName.Text + "%");
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textCustName.Text = reader["CustomerName"].ToString();
                            textCustPhone.Text = reader["CustomerPhone"].ToString();
                            textCustAddress.Text = reader["CustomerAddress"].ToString();
                            dateTime.Text = reader["CustomerDate"].ToString();
                            textCustPrice.Text = reader["CustomerPrice"].ToString();
                            textCustNote.Text = reader["CustomerNote"].ToString();
                            textCustID.Text = reader["CustomerID"].ToString();
                            reader.Close();
                            connection.Close();
                        }
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    dateEnd();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // السماح فقط بالأحرف والأرقام
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true; // منع الإدخال
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textCustPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // منع الإدخال
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textCustID_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "SELECT CustomerID, CustomerName, CustomerPhone, CustomerAddress, CustomerDate, CustomerPrice, CustomerNote FROM Active WHERE CustomerID LIKE ?";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@CustomerID", textCustID.Text + "%");
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textCustName.Text = reader["CustomerName"].ToString();
                            textCustPhone.Text = reader["CustomerPhone"].ToString();
                            textCustAddress.Text = reader["CustomerAddress"].ToString();
                            dateTime.Text = reader["CustomerDate"].ToString();
                            textCustPrice.Text = reader["CustomerPrice"].ToString();
                            textCustNote.Text = reader["CustomerNote"].ToString();
                            textCustID.Text = reader["CustomerID"].ToString();
                            reader.Close();
                            connection.Close();
                        }
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    dateEnd();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dateEnd()
        {
            DateTime registrationDate = dateTime.Value;
            DateTime expirationDate = registrationDate.AddDays(30);
            if (DateTime.Now >= expirationDate)
            {
                MessageBox.Show($"لقد انقضت 30 يومًا منذ تاريخ التسجيل. تاريخ انتهاء الاشتراك هو {expirationDate.ToShortDateString()}", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCustName.BackColor = Color.Red;
                textCustID.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show($"تاريخ انتهاء الاشتراك هو {expirationDate.ToShortDateString()}", "تلميح", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void textCustName_TextChanged(object sender, EventArgs e)
        {
            textCustName.BackColor = Color.Tan;
        }
        private void textCustID_TextChanged(object sender, EventArgs e)
        {
            textCustID.BackColor = Color.Tan;
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // إنشاء النموذج الجديد
            Form companyForm = new Form();
            companyForm.Text = "حول الشركة المطورة";
            companyForm.Size = new System.Drawing.Size(500, 250);
            companyForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            companyForm.StartPosition = FormStartPosition.CenterParent;
            // إضافة وصف الشركة إلى النموذج
            Label DescriptionLabel = new Label();
            DescriptionLabel.Text = "شركة سما المجد للبرمجيات المتقدمة هي شركة رائدة في مجال تطوير البرمجيات\nمتخصصة في تقديم حلول تقنية مبتكرة تلبي احتياجات العملاء في مختلف الصناعات\nتأسست الشركة بهدف تقديم خدمات برمجية عالية الجودة تساهم في تحسين الكفاءة والإنتاجية\nفريقنا يتكون من مجموعة من الخبراء في مجالات البرمجة، التصميم، وإدارة المشاريع\nمما يضمن تقديم منتجات وخدمات تلبي أعلى معايير الجودة.";
            DescriptionLabel.Font = new System.Drawing.Font("Arial", 12);
            DescriptionLabel.Size = new System.Drawing.Size(450, 200);
            DescriptionLabel.Location = new System.Drawing.Point(20, 20);
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            DescriptionLabel.RightToLeft = RightToLeft.Yes;

            // إضافة الوصف إلى النموذج
            companyForm.Controls.Add(DescriptionLabel);
            Label additionalLabel = new Label();
            additionalLabel.Text = "نحن ملتزمون بتقديم أفضل الحلول التقنية لعملائنا.\nللتواصل والاستعلام لا تتردد في التحدث معنا عبر واتساب 01002646280";
            additionalLabel.Font = new System.Drawing.Font("Arial", 12);
            additionalLabel.Size = new System.Drawing.Size(450, 50);
            additionalLabel.Location = new System.Drawing.Point(20, DescriptionLabel.Bottom + 10); // تحديد الموقع بعد الأول مباشرة
            additionalLabel.AutoSize = true;
            additionalLabel.TextAlign = ContentAlignment.MiddleCenter;
            additionalLabel.RightToLeft = RightToLeft.Yes;
            // إضافة Label الآخر إلى النموذج
            companyForm.Controls.Add(additionalLabel);
            companyForm.ShowDialog();
        }
    }
}
