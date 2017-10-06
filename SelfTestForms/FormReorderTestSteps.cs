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
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private List<SelfTestMessageDB> m_SelfTestMessageList;
        private String m_Name;
        private SelfTestMessageDB m_SelfTestMessage;
        private FormHelpPreview m_FormHelpPreview = new FormHelpPreview();


        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormReorderTestSteps(SelfTestDB st)
        {
            InitializeComponent();

            m_SelfTestMessageList = new List<SelfTestMessageDB>(st.messageList);
            m_Name = st.name;
            m_SelfTestMessage = st.description;
            
            PopulateSelfTestMessages();

            ucDS_SelfTestMessageList.SetDualSelectorSupport(this);

            m_FormHelpPreview.Owner = this;

        }

        private FormReorderTestSteps() { }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public List<SelfTestMessageDB> GetEditedSelfTestList()
        {
            m_SelfTestMessageList.Clear();

            foreach (SelfTestMessageDB s in ucDS_SelfTestMessageList.GetReorderItems())
            {
                m_SelfTestMessageList.Add(s);
            }

            return m_SelfTestMessageList;
        }

        ////////////////////////////////////////////////////////////
        // Private methods
        ////////////////////////////////////////////////////////////
        private void PopulateSelfTestMessages()
        {
            if (m_SelfTestMessageList == null)
            {
                return;
            }

            foreach (SelfTestMessageDB stm in m_SelfTestMessageList)
            {
                ucDS_SelfTestMessageList.AddListBoxItem(stm);
            }
        }

        private void CompileHelpTextAndShow()
        {
            String helpText = m_SelfTestMessage.messageText;

            foreach (SelfTestMessageDB s in ucDS_SelfTestMessageList.GetReorderItems())
            {
                helpText += s.messageText;
            }

            m_FormHelpPreview.UpdateForm(helpText);
        }


        ////////////////////////////////////////////////////////////
        // Interface implementations
        ////////////////////////////////////////////////////////////
        public void MoveUp(object obj)
        {
            CompileHelpTextAndShow();
        }

        public void MoveDown(object obj)
        {
            CompileHelpTextAndShow();
        }


        ////////////////////////////////////////////////////////////
        // Control event methods
        ////////////////////////////////////////////////////////////        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UserCancel.Query("Self Test Message List" , m_Name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void checkBoxPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                m_FormHelpPreview.Visible = true;
                CompileHelpTextAndShow();
            }
            else
            {
                m_FormHelpPreview.Visible = false;
            }
        }

    }

}
