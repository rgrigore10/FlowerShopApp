﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
   
    public partial class UserControlEmail : UserControl
    {

        public UserControlEmail()
        {
            InitializeComponent();
            
        }
        public string GetEmail
        {
            get
            {
                return textBox1.Text;
            }
        }
       
    }
}
