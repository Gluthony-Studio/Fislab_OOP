﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Fislab_Project
{
    public class user
    {
        private string _username;
        private string _password;
        private string _email;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public user(string Username, string Password, string Email) 
        {
            username = Username;
            password = Password;
            email = Email;
        }
        public void login()
        {

        }
        public void signup()
        {

        }
    }
}