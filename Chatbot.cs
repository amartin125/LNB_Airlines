using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



    namespace LNB_Airlines
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
                string botResponse = GetChatbotResponse(userInput); // Call it synchronously
                rtbChatHistory.AppendText("Bot: " + botResponse + "\n");
                txtUserInput.Clear();
            }
        }
        // Simulates a typing delay for the bot
        private async Task<string> SimulateTyping(string response)
        {
            await Task.Delay(1000); // 1-second delay
            return response;
        }

        // Method to return chatbot response
        private string GetChatbotResponse(string userInput)
        {
                userInput = userInput.ToLower(); // Simplify input processing


                else if (userInput.Contains("pick up"))
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
                else if (userInput.Contains("how are you"))
                {
                    return "I'm just a chatbot, but I'm ready to assist you with anything you need!";
                }
                else if (userInput.Contains("thank you"))
                {
                    return "You're welcome! Let me know if there's anything else I can help with.";
                }
                else if (userInput.Contains("fun fact"))
                {
                    return "Did you know? The average airplane flies at an altitude of 35,000 feet!";
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
        // Method to request time off
        private string RequestTimeOff(string userInput)
        {
            string[] words = userInput.Split(' ');
            DateTime requestedDate;

            if (words.Contains("on") && DateTime.TryParse(words[Array.IndexOf(words, "on") + 1], out requestedDate))
            {
                return $"Your time-off request for {requestedDate.ToShortDateString()} has been submitted. It will be reviewed.";
            }
            return "Please specify a valid date for your time-off request, e.g., 'request time off on 11/25/2024'.";
        }

        // Method to search for shifts
        private string SearchShifts(string userInput)
        {
            string[] words = userInput.Split(' ');
            string role = words[Array.IndexOf(words, "for") + 1];
            DateTime searchDate;

            if (words.Contains("on") && DateTime.TryParse(words[Array.IndexOf(words, "on") + 1], out searchDate))
            {
                var shifts = availableShifts.Where(s => s.Role.Equals(role, StringComparison.OrdinalIgnoreCase) && s.Date.Date == searchDate.Date && s.IsAvailable);

                if (shifts.Any())
                {
                    return $"Available {role} shifts on {searchDate.ToShortDateString()}:\n" + string.Join("\n", shifts.Select(s => s.ToString()));
                }
                else
                {
                    return $"No available {role} shifts on {searchDate.ToShortDateString()}.";
                }
            }
            return "Please specify the role and date, e.g., 'search for pilot shifts on 11/22/2024'.";
        }


        // Method to view user's shifts
        private string ViewUserShifts()
        {
            var userShifts = availableShifts.Where(s => !s.IsAvailable);

            if (userShifts.Any())
            {
                return "Here are your current shifts:\n" + string.Join("\n", userShifts.Select(s => s.ToString()));
            }
            return "You have no shifts scheduled.";
        }

        // Chatbot form load event
        private void Chatbot_Load(object sender, EventArgs e)
        {
            rtbChatHistory.AppendText("Bot: Hello! You can ask me about your shifts, request time off, or just chat.\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int defaultUserId = 1; // Replace with an appropriate default user ID
            this.Hide();
            EmployeeDash emp = new EmployeeDash(defaultUserId);
            emp.Show();
        }

        private void rtbChatHistory_TextChanged(object sender, EventArgs e)
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