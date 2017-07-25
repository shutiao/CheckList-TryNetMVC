using System;
using System.Collections.Generic;

namespace CheckList.Models
{
    public class Reminder
    {
        public string statement;

        public static void Create(String ReminderTitle){
            var reminder = new Reminder();
            reminder.statement = ReminderTitle;
            if (GlobalVariables.rList == null)
                { GlobalVariables.rList = new List<Reminder>(); }
            GlobalVariables.rList.Add(reminder);
        }

        public static List<Reminder> GetAll(){
            if(GlobalVariables.rList == null){
                GlobalVariables.rList = new List<Reminder>();
            }
            return GlobalVariables.rList;
        }
    }

}