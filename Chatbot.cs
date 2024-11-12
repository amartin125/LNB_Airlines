using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



    namespace Chatbot
    {
        public partial class Chatbot : Form
        {
            // List to hold available shifts for LNB Airlines
            private List<Shift> availableShifts = new List<Shift>
        {
            new Shift("Pilot", DateTime.Now.AddDays(1), "09:00 AM"),
            new Shift("Flight Attendant", DateTime.Now.AddDays(1), "09:00 AM"),
            new Shift("Ground Crew", DateTime.Now.AddDays(2), "01:00 PM"),
        };

            public Chatbot()
            {
                InitializeComponent();
            }

        // Event handler for sending a message
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

        // Method to return chatbot response
        private string GetChatbotResponse(string userInput)
            {
                userInput = userInput.ToLower(); // Simplify input processing

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
                    return "Hello! How can I assist you with your shifts at LNB Airlines today?";
                }
                else if (userInput.Contains("bye"))
                {
                    return "Goodbye! Have a nice day!";
                }
                else
                {
                    return "I'm sorry, I didn't understand that. Try asking about picking up, dropping, or viewing available shifts.";
                }
            }

            // Method to handle picking up a shift
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
                return "Sorry, the shift you requested is not available or doesn't exist.";
            }

            // Method to handle dropping a shift
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

            // Method to list all available shifts
            private string ListAvailableShifts()
            {
                StringBuilder shiftList = new StringBuilder();
                foreach (var shift in availableShifts)
                {
                    if (shift.IsAvailable)
                    {
                        shiftList.AppendLine(shift.ToString());
                    }
                }
                return shiftList.Length > 0 ? shiftList.ToString() : "No shifts are currently available.";
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    // Shift class to represent each shift with role, date, and time
    public class Shift
        {
            public string Role { get; set; }
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public bool IsAvailable { get; set; }

            public Shift(string role, DateTime date, string time)
            {
                Role = role;
                Date = date;
                Time = time;
                IsAvailable = true;
            }

            public override string ToString()
            {
                return $"{Role} shift on {Date.ToShortDateString()} at {Time}";
            }
        }
    }