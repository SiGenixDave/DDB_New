using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormReorderTestSteps : Form , iDualSelectorSupport
    {
        List<SelfTestMessageDB> m_StmList;
        String m_Name;
        String m_Description;
        FormHelpPreview fhp = new FormHelpPreview();

        public FormReorderTestSteps(SelfTestDB st)
        {
            InitializeComponent();

            m_StmList = new List<SelfTestMessageDB>(st.messageList);
            m_Name = st.name;
            m_Description = st.descriptionText;
            
            PopulateSelfTestMessages();

            ucDS_SelfTestMessageList.SetDualSelectorSupport(this);

            fhp.Owner = this;

        }

        private FormReorderTestSteps() { } 

        public List<SelfTestMessageDB> GetEditedSelfTestList()
        {
            m_StmList.Clear();

            foreach (SelfTestMessageDB s in ucDS_SelfTestMessageList.GetReorderItems())
            {
                m_StmList.Add(s);
            }

            return m_StmList;
        }

        private void PopulateSelfTestMessages()
        {
            if (m_StmList == null)
            {
                return;
            }

            foreach (SelfTestMessageDB stm in m_StmList)
            {
                ucDS_SelfTestMessageList.AddListBoxItem(stm);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Self Test Message List" , m_Name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }


        public void MoveUp(object obj)
        {
            CompileHelpTextAndShow();
        }

        public void MoveDown(object obj)
        {
            CompileHelpTextAndShow();
        }

        private void checkBoxPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                fhp.Visible = true;
                CompileHelpTextAndShow();
            }
            else
            {
                fhp.Visible = false;
            }
        }

        private void CompileHelpTextAndShow()
        {
            String helpText = m_Description;

            foreach (SelfTestMessageDB s in ucDS_SelfTestMessageList.GetReorderItems())
            {
                helpText += s.messageText;
            }

            fhp.UpdateForm(helpText);
        }
    }

}
