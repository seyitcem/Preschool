﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Preschool_Client.Connection;
using static Preschool_Client.Transform;

namespace Preschool_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement query = new XElement("GET",
                                    new XElement("SELECT",
                                        new XElement("Element", "price"),
                                        new XElement("Element", "amount")),
                                    new XElement("FROM",
                                        new XElement("Table_Name", "Products"))
            );
            SendNewMessage(StringToHexString(query.ToString()));
        }
    }
}