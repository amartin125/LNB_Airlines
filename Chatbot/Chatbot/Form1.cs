using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LnbChatBot;

namespace LnbChatBot
{
    public partial class Form1 : Form
    {
        
        private List<Shift> availableShifts = new List<Shift>
        {
            new Shift("Pilot", DateTime.Now.AddDays(1), "09:00 AM"),
            new Shift("Chief Operator", DateTime.Now.AddDays(2), "12:00 PM"),
            new Shift("Ground Crew", DateTime.Now.AddDays(3), "02:00 PM")
        };

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSend_Click(object sender, EventArgs e)
        {
            
            string userInput = txtUserInput.Text.Trim();

            if (!string.IsNullOrEmpty(userInput))
            {
              
                rtbChatHistory.AppendText("You: " + userInput + "\n");

                
                string botResponse = GetChatbotResponse(userInput);

                
                rtbChatHistory.AppendText("Bot: " + botResponse + "\n");

                
                txtUserInput.Clear();
            }
        }

        
        private string GetChatbotResponse(string userInput)
        {
            userInput = userInput.ToLower(); 

            if (userInput.Contains("pick up"))
            {
                return PickUpShift(userInput);
            }
            else if (userInput.Contains("drop"))
            {
                return DropShift(userInput);
            }
            else if (userInput.Contains("view shifts"))
            {
                return ListAvailableShifts();
            }
            else if (userInput.Contains("hello"))
            {
                return "Hello! How can I assist you with your shifts today?";
            }
            else if (userInput.Contains("bye"))
            {
                return "Goodbye! Have a nice day!";
            }
            else
            {
                return "I'm sorry, I didn't understand that. Try asking about picking up, dropping, or viewing shifts.";
            }
        }

       
        private string PickUpShift(string userInput)
        {
            foreach (var shift in availableShifts)
            {
                if (userInput.Contains(shift.Role.ToLower()) && userInput.Contains(shift.Date.ToShortDateString()))
                {
                    if (shift.IsAvailable)
                    {
                        shift.IsAvailable = false;
                        return $"You have successfully picked up the {shift.Role} shift on {shift.Date.ToShortDateString()} at {shift.Time}.";
                    }
                    else
                    {
                        return $"Sorry, the {shift.Role} shift on {shift.Date.ToShortDateString()} at {shift.Time} is already taken.";
                    }
                }
            }
            return "Sorry, the shift you requested is not available.";
        }

        
        private string DropShift(string userInput)
        {
            foreach (var shift in availableShifts)
            {
                if (userInput.Contains(shift.Role.ToLower()) && userInput.Contains(shift.Date.ToShortDateString()))
                {
                    if (!shift.IsAvailable)
                    {
                        shift.IsAvailable = true;
                        return $"You have successfully dropped the {shift.Role} shift on {shift.Date.ToShortDateString()} at {shift.Time}.";
                    }
                    else
                    {
                        return $"You don't have the {shift.Role} shift on {shift.Date.ToShortDateString()} to drop.";
                    }
                }
            }
            return "Sorry, the shift you are trying to drop is not found.";
        }

        
        private string ListAvailableShifts()
        {
            System.Text.StringBuilder shiftList = new System.Text.StringBuilder();
            foreach (var shift in availableShifts)
            {
                if (shift.IsAvailable)
                {
                    shiftList.AppendLine(shift.ToString());
                }
            }
            return shiftList.Length > 0 ? shiftList.ToString() : "No shifts are currently available.";
        }
    }
}
