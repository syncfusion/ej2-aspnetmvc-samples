using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2MVCSampleBrowser.Models
{
    public class ScheduleEvents
    {
        private static DateTime Today = DateTime.Now;
        private int CurrentYear = Today.Year;
        public List<AppointmentData> GetAppointmentData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 11, 0, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 1, 10, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 14, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Meteor Showers in 2021",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 12, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 14, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Milky Way as Melting pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 14, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(CurrentYear, 1, 13, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(CurrentYear, 1, 14, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 15, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 17, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(CurrentYear, 1, 19, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Best Photography 2021",
                Location = "London",
                StartTime = new DateTime(CurrentYear, 1, 20, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(CurrentYear, 1, 7, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 4, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 18, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(CurrentYear, 1, 21, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 10, 5, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 7, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 10, 17, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 18, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Fransisco",
                StartTime = new DateTime(CurrentYear, 1, 13, 6, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 7, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 13, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 18, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 11, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 16, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(CurrentYear, 1, 14, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 15, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            return appData;
        }
        public List<AppointmentData> GetConcurrentData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 25, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 11, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 5, 26, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 14, 0, 0),
                CategoryColor = "#357cd2",
                IsAllDay = true
            });
            appData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 27, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 27, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Meteor Showers in 2022",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 28, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 14, 30, 0),
                CategoryColor = "#ea7a57",
                IsAllDay = true
            });
            appData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Milky Way as Melting Pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 29, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 29, 14, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(CurrentYear, 5, 25, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 11, 0, 0),
                CategoryColor = "#8e24aa"
            });
            appData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(CurrentYear, 5, 26, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 12, 30, 0),
                CategoryColor = "#8e24aa"
            });
            appData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 24, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 24, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 28, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(CurrentYear, 5, 28, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 17, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Best Photography 2022",
                Location = "London",
                StartTime = new DateTime(CurrentYear, 5, 25, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(CurrentYear, 5, 26, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 27, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 27, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 5, 28, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 5, 29, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 29, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(CurrentYear, 5, 25, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 5, 26, 5, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 7, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 27, 17, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 27, 18, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Francisco",
                StartTime = new DateTime(CurrentYear, 5, 28, 6, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 7, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 29, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 29, 18, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 25, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 5, 26, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 16, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(CurrentYear, 5, 27, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 27, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 5, 28, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 25,
                Subject = "Solar Flare Observation",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 29, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 29, 12, 0, 0),
                CategoryColor = "#ff5733"
            });
            appData.Add(new AppointmentData
            {
                Id = 26,
                Subject = "Astronomy Workshop",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 5, 25, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 13, 0, 0),
                CategoryColor = "#33c1ff"
            });
            appData.Add(new AppointmentData
            {
                Id = 27,
                Subject = "Rocket Engine Testing",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 5, 26, 6, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 8, 0, 0),
                CategoryColor = "#9c27b0"
            });
            appData.Add(new AppointmentData
            {
                Id = 28,
                Subject = "Satellite Communication Drill",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 27, 7, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 27, 9, 0, 0),
                CategoryColor = "#4caf50"
            });
            appData.Add(new AppointmentData
            {
                Id = 29,
                Subject = "Asteroid Tracking Session",
                Location = "Bermuda",
                StartTime = new DateTime(CurrentYear, 5, 28, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 12, 0, 0),
                CategoryColor = "#ff9800"
            });
            appData.Add(new AppointmentData
            {
                Id = 30,
                Subject = "Deep Space Signals Analysis",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 28, 16, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 17, 30, 0),
                CategoryColor = "#3f51b5"
            });
            appData.Add(new AppointmentData
            {
                Id = 31,
                Subject = "Comet Observation",
                Location = "Himalayas",
                StartTime = new DateTime(CurrentYear, 5, 25, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 15, 0, 0),
                CategoryColor = "#795548"
            });
            appData.Add(new AppointmentData
            {
                Id = 32,
                Subject = "Space Debris Monitoring",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 26, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 26, 16, 0, 0),
                CategoryColor = "#009688"
            });
            appData.Add(new AppointmentData
            {
                Id = 33,
                Subject = "Planetary Alignment Study",
                Location = "Alaska",
                StartTime = new DateTime(CurrentYear, 5, 27, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 27, 10, 0, 0),
                CategoryColor = "#673ab7"
            });
            appData.Add(new AppointmentData
            {
                Id = 34,
                Subject = "Interstellar Research Briefing",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 5, 28, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 28, 11, 30, 0),
                CategoryColor = "#e91e63"
            });
            appData.Add(new AppointmentData
            {
                Id = 35,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 5, 25, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 25, 13, 0, 0),
                CategoryColor = "#33c1ff"
            });
            return appData;
        }
        public List<AppointmentData> GetOverlappingData()
        {
            List<AppointmentData> overlapEventData = new List<AppointmentData>();
            overlapEventData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Holiday Market",
                Location = "City Square",
                StartTime = new DateTime(CurrentYear, 2, 2, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 2, 12, 0, 0),
                CategoryColor = "#ff0000"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Christmas Caroling",
                Location = "Town Hall",
                StartTime = new DateTime(CurrentYear, 2, 2, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 2, 13, 0, 0),
                CategoryColor = "#00ff00"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Gingerbread House Workshop",
                Location = "Community Center",
                StartTime = new DateTime(CurrentYear, 2, 5, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 5, 11, 0, 0),
                CategoryColor = "#0000ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Winter Wonderland",
                Location = "Central Park",
                StartTime = new DateTime(CurrentYear, 2, 5, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 5, 12, 30, 0),
                CategoryColor = "#ff00ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Santa's Grotto",
                Location = "Shopping Mall",
                StartTime = new DateTime(CurrentYear, 2, 6, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 6, 16, 0, 0),
                CategoryColor = "#00ffff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Ice Sculpture Contest",
                Location = "City Center",
                StartTime = new DateTime(CurrentYear, 2, 7, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 7, 17, 0, 0),
                CategoryColor = "#ff8000"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Hot Cocoa Social",
                Location = "Community Hall",
                StartTime = new DateTime(CurrentYear, 2, 8, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 8, 12, 0, 0),
                CategoryColor = "#8000ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Snowflake Ball",
                Location = "Grand Ballroom",
                StartTime = new DateTime(CurrentYear, 2, 9, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 9, 13, 30, 0),
                CategoryColor = "#ff0080"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Reindeer Games",
                Location = "Local Park",
                StartTime = new DateTime(CurrentYear, 2, 10, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 10, 11, 0, 0),
                CategoryColor = "#0080ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Elf Workshop",
                Location = "Toy Store",
                StartTime = new DateTime(CurrentYear, 2, 11, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 11, 12, 30, 0),
                CategoryColor = "#ff8000"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Holiday Parade",
                Location = "Main Street",
                StartTime = new DateTime(CurrentYear, 2, 12, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 12, 15, 0, 0),
                CategoryColor = "#800080"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Christmas Tree Lighting",
                Location = "City Hall",
                StartTime = new DateTime(CurrentYear, 2, 13, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 13, 16, 30, 0),
                CategoryColor = "#ff00ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Holiday Baking Class",
                Location = "Culinary School",
                StartTime = new DateTime(CurrentYear, 2, 14, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 14, 13, 0, 0),
                CategoryColor = "#00ff80"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Winter Fair",
                Location = "Fairgrounds",
                StartTime = new DateTime(CurrentYear, 2, 15, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 15, 14, 30, 0),
                CategoryColor = "#ff0080"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Parrot Show",
                Location = "Zoo",
                StartTime = new DateTime(CurrentYear, 2, 5, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 5, 15, 0, 0),
                CategoryColor = "#cddc39"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Seal Show",
                Location = "Aquarium",
                StartTime = new DateTime(CurrentYear, 2, 6, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 6, 16, 0, 0),
                CategoryColor = "#ff9800"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "Dolphin Show",
                Location = "Marine Park",
                StartTime = new DateTime(CurrentYear, 2, 7, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 7, 11, 0, 0),
                CategoryColor = "#795548"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Shark Feeding",
                Location = "Aquarium",
                StartTime = new DateTime(CurrentYear, 2, 8, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 8, 13, 0, 0),
                CategoryColor = "#607d8b"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Otter Show",
                Location = "Zoo",
                StartTime = new DateTime(CurrentYear, 2, 9, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 9, 15, 0, 0),
                CategoryColor = "#e91e63"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Crocodile Feeding",
                Location = "Reptile House",
                StartTime = new DateTime(CurrentYear, 2, 10, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 10, 16, 0, 0),
                CategoryColor = "#9e9e9e"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Panda Playtime",
                Location = "Zoo",
                StartTime = new DateTime(CurrentYear, 2, 11, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 11, 11, 30, 0),
                CategoryColor = "#ff4081"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "Tiger Talk",
                Location = "Big Cat Enclosure",
                StartTime = new DateTime(CurrentYear, 2, 12, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 12, 14, 0, 0),
                CategoryColor = "#8e24aa"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Holiday Market",
                Location = "Town Square",
                StartTime = new DateTime(CurrentYear, 2, 13, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 13, 12, 0, 0),
                CategoryColor = "#ff0000"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Christmas Caroling",
                Location = "Community Center",
                StartTime = new DateTime(CurrentYear, 2, 13, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 13, 13, 0, 0),
                CategoryColor = "#00ff00"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 25,
                Subject = "Gingerbread House Workshop",
                Location = "Bakery",
                StartTime = new DateTime(CurrentYear, 2, 16, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 16, 11, 0, 0),
                CategoryColor = "#0000ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 26,
                Subject = "Winter Wonderland",
                Location = "Ski Resort",
                StartTime = new DateTime(CurrentYear, 2, 16, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 16, 12, 30, 0),
                CategoryColor = "#ff00ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 27,
                Subject = "Santa's Grotto",
                Location = "Department Store",
                StartTime = new DateTime(CurrentYear, 2, 17, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 17, 16, 0, 0),
                CategoryColor = "#00ffff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 28,
                Subject = "Ice Sculpture Contest",
                Location = "Town Square",
                StartTime = new DateTime(CurrentYear, 2, 17, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 17, 17, 0, 0),
                CategoryColor = "#ff8000"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 29,
                Subject = "Hot Cocoa Social",
                Location = "Cafe",
                StartTime = new DateTime(CurrentYear, 2, 18, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 18, 12, 0, 0),
                CategoryColor = "#8000ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 30,
                Subject = "Snowflake Ball",
                Location = "City Hall",
                StartTime = new DateTime(CurrentYear, 2, 19, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 19, 13, 30, 0),
                CategoryColor = "#ff0080"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 31,
                Subject = "Reindeer Games",
                Location = "Community Park",
                StartTime = new DateTime(CurrentYear, 2, 20, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 20, 11, 0, 0),
                CategoryColor = "#0080ff"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 32,
                Subject = "Elf Workshop",
                Location = "Community Center",
                StartTime = new DateTime(CurrentYear, 2, 21, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 21, 12, 30, 0),
                CategoryColor = "#ff8000"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 33,
                Subject = "Holiday Parade",
                Location = "Main Street",
                StartTime = new DateTime(CurrentYear, 2, 22, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 22, 15, 0, 0),
                CategoryColor = "#800080"
            });
            overlapEventData.Add(new AppointmentData
            {
                Id = 34,
                Subject = "Christmas Tree Lighting",
                Location = "Town Square",
                StartTime = new DateTime(CurrentYear, 2, 22, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 22, 16, 30, 0),
                CategoryColor = "#ff00ff"
            });
            return overlapEventData;
        }

        public List<TaskData> GetTaskData()
        {
            List<TaskData> taskData = new List<TaskData>();
            taskData.Add(new TaskData {
                Id = 1,
                Subject = "Frontend Architecture Design",
                StartTime = new DateTime(2026, 4, 21, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 10, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Design React component architecture"
            });

            taskData.Add(new TaskData {
                Id = 2,
                Subject = "UI Component Development",
                StartTime = new DateTime(2026, 4, 21, 11, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 13, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Build reusable UI component library"
            });

            taskData.Add(new TaskData {
                Id = 13,
                Subject = "Code Review & Testing",
                StartTime = new DateTime(2026, 4, 21, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 15, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Peer code review and testing"
            });

            taskData.Add(new TaskData {
                Id = 3,
                Subject = "API Gateway Configuration",
                StartTime = new DateTime(2026, 4, 21, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 11, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Setup API gateway with authentication"
            });

            taskData.Add(new TaskData {
                Id = 4,
                Subject = "Database Migration",
                StartTime = new DateTime(2026, 4, 21, 11, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 13, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Execute production database migration"
            });

            taskData.Add(new TaskData {
                Id = 14,
                Subject = "Performance Monitoring",
                StartTime = new DateTime(2026, 4, 21, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 16, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Setup monitoring and alerts"
            });

            taskData.Add(new TaskData {
                Id = 5,
                Subject = "Component Testing Suite",
                StartTime = new DateTime(2026, 4, 21, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 11, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Write unit tests for all components"
            });

            taskData.Add(new TaskData {
                Id = 6,
                Subject = "E2E Integration Testing",
                StartTime = new DateTime(2026, 4, 21, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 13, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "End-to-end test automation setup"
            });

            taskData.Add(new TaskData {
                Id = 15,
                Subject = "Test Documentation",
                StartTime = new DateTime(2026, 4, 21, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 16, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Document test cases and scenarios"
            });

            taskData.Add(new TaskData {
                Id = 7,
                Subject = "Performance Optimization",
                StartTime = new DateTime(2026, 4, 21, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 12, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Optimize bundle size and loading"
            });

            taskData.Add(new TaskData {
                Id = 8,
                Subject = "Documentation & Deployment",
                StartTime = new DateTime(2026, 4, 21, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 16, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Complete documentation and CI/CD setup"
            });

            taskData.Add(new TaskData {
                Id = 9,
                Subject = "Security Audit & Review",
                StartTime = new DateTime(2026, 4, 21, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 11, 30, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "OWASP security compliance review"
            });

            taskData.Add(new TaskData {
                Id = 10,
                Subject = "Accessibility Compliance Check",
                StartTime = new DateTime(2026, 4, 21, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 13, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "WCAG 2.1 AA compliance verification"
            });

            taskData.Add(new TaskData {
                Id = 16,
                Subject = "Compliance Report",
                StartTime = new DateTime(2026, 4, 21, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 16, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Generate compliance documentation"
            });

            taskData.Add(new TaskData {
                Id = 11,
                Subject = "Sprint Planning & Coordination",
                StartTime = new DateTime(2026, 4, 21, 10, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 11, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Sprint planning and backlog refinement"
            });

            taskData.Add(new TaskData {
                Id = 12,
                Subject = "Release Management & QA",
                StartTime = new DateTime(2026, 4, 21, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 13, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Final QA and release coordination"
            });

            taskData.Add(new TaskData {
                Id = 17,
                Subject = "Team Sync & Standup",
                StartTime = new DateTime(2026, 4, 21, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 15, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Daily standup and team sync"
            });

            taskData.Add(new TaskData {
                Id = 18,
                Subject = "User Experience Testing",
                StartTime = new DateTime(2026, 4, 21, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 18, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "User acceptance testing phase"
            });

            taskData.Add(new TaskData {
                Id = 19,
                Subject = "Production Deployment Review",
                StartTime = new DateTime(2026, 4, 21, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 17, 30, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Final production deployment review"
            });

            taskData.Add(new TaskData {
                Id = 20,
                Subject = "Performance Analysis & Reporting",
                StartTime = new DateTime(2026, 4, 21, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 18, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Analyze performance metrics and generate reports"
            });

            taskData.Add(new TaskData {
                Id = 21,
                Subject = "System Integration Testing",
                StartTime = new DateTime(2026, 4, 21, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 21, 17, 30, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Comprehensive system integration testing"
            });

            taskData.Add(new TaskData {
                Id = 22,
                Subject = "Final Security Sign-off",
                StartTime = new DateTime(2026, 4, 21, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 18, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Final security approval and sign-off"
            });

            taskData.Add(new TaskData {
                Id = 23,
                Subject = "Release Deployment & Handoff",
                StartTime = new DateTime(2026, 4, 21, 15, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 16, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Production release deployment and team handoff"
            });

            taskData.Add(new TaskData {
                Id = 24,
                Subject = "Post-Deployment Monitoring",
                StartTime = new DateTime(2026, 4, 21, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 21, 18, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Monitor system post-deployment"
            });

            taskData.Add(new TaskData {
                Id = 25,
                Subject = "Project Scope Finalization",
                StartTime = new DateTime(2026, 4, 20, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 10, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Finalize project scope and objectives"
            });
            taskData.Add(new TaskData {
                Id = 26,
                Subject = "UI Design Sign-off",
                StartTime = new DateTime(2026, 4, 20, 11, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 13, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Approve final UI designs"
            });

            taskData.Add(new TaskData {
                Id = 27,
                Subject = "UX Review Session",
                StartTime = new DateTime(2026, 4, 20, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 15, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Review UX flow and interactions"
            });

            taskData.Add(new TaskData {
                Id = 28,
                Subject = "Service Endpoint Finalization",
                StartTime = new DateTime(2026, 4, 20, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 20, 11, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Finalize backend service endpoints"
            });

            taskData.Add(new TaskData {
                Id = 29,
                Subject = "Database Constraint Validation",
                StartTime = new DateTime(2026, 4, 20, 11, 30, 0),
                EndTime = new DateTime(2026, 4, 20, 13, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Validate database constraints"
            });

            taskData.Add(new TaskData {
                Id = 30,
                Subject = "Infrastructure Checklist Review",
                StartTime = new DateTime(2026, 4, 20, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 20, 15, 30, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Review infrastructure readiness checklist"
            });

            taskData.Add(new TaskData {
                Id = 31,
                Subject = "Unit Test Completion",
                StartTime = new DateTime(2026, 4, 20, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 11, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Complete unit test implementation"
            });

            taskData.Add(new TaskData {
                Id = 32,
                Subject = "Automation Report Review",
                StartTime = new DateTime(2026, 4, 20, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 13, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Review automation execution report"
            });

            taskData.Add(new TaskData {
                Id = 33,
                Subject = "Regression Planning",
                StartTime = new DateTime(2026, 4, 20, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 15, 30, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "pending",
                Progress = 67,
                Description = "Plan regression testing cycle"
            });

            taskData.Add(new TaskData {
                Id = 34,
                Subject = "Build Optimization Completion",
                StartTime = new DateTime(2026, 4, 20, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 20, 12, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Complete build optimization tasks"
            });

            taskData.Add(new TaskData {
                Id = 35,
                Subject = "Deployment Script Validation",
                StartTime = new DateTime(2026, 4, 20, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 16, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Validate deployment scripts"
            });

            taskData.Add(new TaskData {
                Id = 36,
                Subject = "Security Controls Verification",
                StartTime = new DateTime(2026, 4, 20, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 11, 30, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Verify implemented security controls"
            });

            taskData.Add(new TaskData {
                Id = 37,
                Subject = "Compliance Evidence Submission",
                StartTime = new DateTime(2026, 4, 20, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 13, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Submit compliance evidence"
            });

            taskData.Add(new TaskData {
                Id = 38,
                Subject = "Audit Observation Review",
                StartTime = new DateTime(2026, 4, 20, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 20, 15, 30, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Review audit observations"
            });

            taskData.Add(new TaskData {
                Id = 39,
                Subject = "Sprint Closure Meeting",
                StartTime = new DateTime(2026, 4, 20, 10, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 11, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Conduct sprint closure meeting"
            });

            taskData.Add(new TaskData {
                Id = 40,
                Subject = "Release Checklist Completion",
                StartTime = new DateTime(2026, 4, 20, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 13, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Complete release checklist"
            });

            taskData.Add(new TaskData {
                Id = 41,
                Subject = "Team Sync Preparation",
                StartTime = new DateTime(2026, 4, 20, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 15, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "pending",
                Progress = 12,
                Description = "Prepare agenda for team sync"
            });

            taskData.Add(new TaskData {
                Id = 42,
                Subject = "UAT Sign-off",
                StartTime = new DateTime(2026, 4, 20, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 18, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "User acceptance testing sign-off"
            });

            taskData.Add(new TaskData {
                Id = 43,
                Subject = "Production Review",
                StartTime = new DateTime(2026, 4, 20, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 17, 30, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Production readiness review"
            });

            taskData.Add(new TaskData {
                Id = 44,
                Subject = "Performance Validation",
                StartTime = new DateTime(2026, 4, 20, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 20, 18, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Validate performance metrics"
            });

            taskData.Add(new TaskData {
                Id = 45,
                Subject = "System Integration Approval",
                StartTime = new DateTime(2026, 4, 20, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 18, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Approve system integration"
            });

            taskData.Add(new TaskData {
                Id = 46,
                Subject = "Final Security Clearance",
                StartTime = new DateTime(2026, 4, 20, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 18, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Provide final security clearance"
            });

            taskData.Add(new TaskData {
                Id = 47,
                Subject = "Release Execution",
                StartTime = new DateTime(2026, 4, 20, 15, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 16, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Execute production release"
            });

            taskData.Add(new TaskData {
                Id = 48,
                Subject = "Post-release Monitoring Setup",
                StartTime = new DateTime(2026, 4, 20, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 20, 18, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Setup post-release monitoring"
            });

            taskData.Add(new TaskData {
                Id = 49,
                Subject = "Feature Requirement Freeze",
                StartTime = new DateTime(2026, 4, 22, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 10, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Freeze feature requirements for release"
            });

            taskData.Add(new TaskData {
                Id = 50,
                Subject = "UI Consistency Verification",
                StartTime = new DateTime(2026, 4, 22, 11, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 13, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Verify UI consistency across modules"
            });

            taskData.Add(new TaskData {
                Id = 51,
                Subject = "Design Review Validation",
                StartTime = new DateTime(2026, 4, 22, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 15, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Validate final design changes"
            });

            taskData.Add(new TaskData {
                Id = 52,
                Subject = "Service Health Check",
                StartTime = new DateTime(2026, 4, 22, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 11, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Run backend service health checks"
            });

            taskData.Add(new TaskData {
                Id = 53,
                Subject = "Data Integrity Confirmation",
                StartTime = new DateTime(2026, 4, 22, 11, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 13, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Confirm migrated data integrity"
            });

            taskData.Add(new TaskData {
                Id = 54,
                Subject = "Metrics Review",
                StartTime = new DateTime(2026, 4, 22, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 16, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Review collected performance metrics"
            });

            taskData.Add(new TaskData {
                Id = 55,
                Subject = "Test Execution Closure",
                StartTime = new DateTime(2026, 4, 22, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 11, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Close remaining test executions"
            });

            taskData.Add(new TaskData {
                Id = 56,
                Subject = "Automation Result Review",
                StartTime = new DateTime(2026, 4, 22, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 13, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "Review automation test results"
            });

            taskData.Add(new TaskData {
                Id = 57,
                Subject = "Test Report Finalization",
                StartTime = new DateTime(2026, 4, 22, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 16, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Finalize overall test report"
            });

            taskData.Add(new TaskData {
                Id = 58,
                Subject = "Build Artifact Validation",
                StartTime = new DateTime(2026, 4, 22, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 12, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Validate generated build artifacts"
            });

            taskData.Add(new TaskData {
                Id = 59,
                Subject = "Deployment Dry Run",
                StartTime = new DateTime(2026, 4, 22, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 16, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Perform deployment dry run"
            });

            taskData.Add(new TaskData {
                Id = 60,
                Subject = "Security Control Confirmation",
                StartTime = new DateTime(2026, 4, 22, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 11, 30, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Confirm applied security controls"
            });

            taskData.Add(new TaskData {
                Id = 61,
                Subject = "Compliance Evidence Review",
                StartTime = new DateTime(2026, 4, 22, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 13, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Review submitted compliance evidence"
            });

            taskData.Add(new TaskData {
                Id = 62,
                Subject = "Audit Closure Documentation",
                StartTime = new DateTime(2026, 4, 22, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 16, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Prepare audit closure documents"
            });

            taskData.Add(new TaskData {
                Id = 63,
                Subject = "Sprint Metrics Review",
                StartTime = new DateTime(2026, 4, 22, 10, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 11, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Review sprint performance metrics"
            });

            taskData.Add(new TaskData {
                Id = 64,
                Subject = "Release Checklist Validation",
                StartTime = new DateTime(2026, 4, 22, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 13, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Validate release readiness checklist"
            });

            taskData.Add(new TaskData {
                Id = 65,
                Subject = "Team Sync Review",
                StartTime = new DateTime(2026, 4, 22, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 15, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Review team sync outcomes"
            });

            taskData.Add(new TaskData {
                Id = 66,
                Subject = "UAT Result Verification",
                StartTime = new DateTime(2026, 4, 22, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 18, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Verify UAT results"
            });

            taskData.Add(new TaskData {
                Id = 67,
                Subject = "Production Approval",
                StartTime = new DateTime(2026, 4, 22, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 17, 30, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Approve production deployment"
            });

            taskData.Add(new TaskData {
                Id = 68,
                Subject = "Performance Summary Report",
                StartTime = new DateTime(2026, 4, 22, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 18, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "done",
                Progress = 100,
                Description = "Prepare performance summary report"
            });

            taskData.Add(new TaskData {
                Id = 69,
                Subject = "Integration Sign-off",
                StartTime = new DateTime(2026, 4, 22, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 17, 30, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "done",
                Progress = 100,
                Description = "Provide integration sign-off"
            });

            taskData.Add(new TaskData {
                Id = 70,
                Subject = "Security Closure Approval",
                StartTime = new DateTime(2026, 4, 22, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 18, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Approve security closure"
            });

            taskData.Add(new TaskData {
                Id = 71,
                Subject = "Release Execution Review",
                StartTime = new DateTime(2026, 4, 22, 15, 0, 0),
                EndTime = new DateTime(2026, 4, 22, 16, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Review release execution"
            });

            taskData.Add(new TaskData {
                Id = 72,
                Subject = "Post-release Health Check",
                StartTime = new DateTime(2026, 4, 22, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 22, 18, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "done",
                Progress = 100,
                Description = "Perform post-release system health check"
            });

            taskData.Add(new TaskData {
                Id = 73,
                Subject = "Architecture Validation Session",
                StartTime = new DateTime(2026, 4, 23, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 10, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Validate overall system architecture"
            });

            taskData.Add(new TaskData {
                Id = 74,
                Subject = "UI Regression Assessment",
                StartTime = new DateTime(2026, 4, 23, 11, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 13, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Assess UI regressions after fixes"
            });

            taskData.Add(new TaskData {
                Id = 75,
                Subject = "UX Feedback Consolidation",
                StartTime = new DateTime(2026, 4, 23, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 15, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "pending",
                Progress = 22,
                Description = "Consolidate UX feedback items"
            });
            taskData.Add(new TaskData {
                Id = 76,
                Subject = "Gateway Performance Review",
                StartTime = new DateTime(2026, 4, 23, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 11, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Review API gateway performance metrics"
            });

            taskData.Add(new TaskData {
                Id = 77,
                Subject = "Data Consistency Audit",
                StartTime = new DateTime(2026, 4, 23, 11, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 13, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Audit data consistency across services"
            });

            taskData.Add(new TaskData {
                Id = 78,
                Subject = "Alert Threshold Planning",
                StartTime = new DateTime(2026, 4, 23, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 16, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "pending",
                Progress = 0,
                Description = "Plan alert threshold values"
            });

            taskData.Add(new TaskData {
                Id = 79,
                Subject = "Test Result Review",
                StartTime = new DateTime(2026, 4, 23, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 11, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "Review executed test results"
            });

            taskData.Add(new TaskData {
                Id = 80,
                Subject = "Automation Gap Analysis",
                StartTime = new DateTime(2026, 4, 23, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 13, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "Analyze gaps in test automation"
            });

            taskData.Add(new TaskData {
                Id = 81,
                Subject = "Test Scenario Backlog",
                StartTime = new DateTime(2026, 4, 23, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 16, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "pending",
                Progress = 35,
                Description = "Prepare backlog of missing scenarios"
            });

            taskData.Add(new TaskData {
                Id = 82,
                Subject = "Build Stability Verification",
                StartTime = new DateTime(2026, 4, 23, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 12, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "review",
                Progress = 99,
                Description = "Verify build stability"
            });

            taskData.Add(new TaskData {
                Id = 83,
                Subject = "Deployment Risk Assessment",
                StartTime = new DateTime(2026, 4, 23, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 16, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "review",
                Progress = 99,
                Description = "Assess deployment risks"
            });

            taskData.Add(new TaskData {
                Id = 84,
                Subject = "Security Finding Review",
                StartTime = new DateTime(2026, 4, 23, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 11, 30, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Review identified security findings"
            });

            taskData.Add(new TaskData {
                Id = 85,
                Subject = "Compliance Gap Analysis",
                StartTime = new DateTime(2026, 4, 23, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 13, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Analyze compliance gaps"
            });

            taskData.Add(new TaskData {
                Id = 86,
                Subject = "Policy Update Draft",
                StartTime = new DateTime(2026, 4, 23, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 16, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "pending",
                Progress = 10,
                Description = "Draft security policy updates"
            });

            taskData.Add(new TaskData {
                Id = 87,
                Subject = "Sprint Review Meeting",
                StartTime = new DateTime(2026, 4, 23, 10, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 11, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Conduct sprint review meeting"
            });

            taskData.Add(new TaskData {
                Id = 88,
                Subject = "Release Risk Evaluation",
                StartTime = new DateTime(2026, 4, 23, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 13, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Evaluate release risks"
            });

            taskData.Add(new TaskData {
                Id = 89,
                Subject = "Standup Action Items",
                StartTime = new DateTime(2026, 4, 23, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 15, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "pending",
                Progress = 0,
                Description = "Track standup action items"
            });

            taskData.Add(new TaskData {
                Id = 90,
                Subject = "UAT Defect Verification",
                StartTime = new DateTime(2026, 4, 23, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 18, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Verify UAT reported defects"
            });

            taskData.Add(new TaskData {
                Id = 91,
                Subject = "Production Rollback Readiness",
                StartTime = new DateTime(2026, 4, 23, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 17, 30, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "done",
                Progress = 100,
                Description = "Ensure rollback readiness"
            });

            taskData.Add(new TaskData {
                Id = 92,
                Subject = "Performance Anomaly Review",
                StartTime = new DateTime(2026, 4, 23, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 18, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "Review performance anomalies"
            });

            taskData.Add(new TaskData {
                Id = 93,
                Subject = "Integration Approval Review",
                StartTime = new DateTime(2026, 4, 23, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 17, 30, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "review",
                Progress = 99,
                Description = "Review integration approval status"
            });

            taskData.Add(new TaskData {
                Id = 94,
                Subject = "Security Exception Closure",
                StartTime = new DateTime(2026, 4, 23, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 18, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "done",
                Progress = 100,
                Description = "Close security exceptions"
            });

            taskData.Add(new TaskData {
                Id = 95,
                Subject = "Release Decision Review",
                StartTime = new DateTime(2026, 4, 23, 15, 0, 0),
                EndTime = new DateTime(2026, 4, 23, 16, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Review go/no-go release decision"
            });

            taskData.Add(new TaskData {
                Id = 96,
                Subject = "Post-release Issue Tracking",
                StartTime = new DateTime(2026, 4, 23, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 23, 18, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Track post-release issues"
            });

            taskData.Add(new TaskData {
                Id = 97,
                Subject = "Final Architecture Confirmation",
                StartTime = new DateTime(2026, 4, 24, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 10, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "done",
                Progress = 100,
                Description = "Confirm final frontend architecture"
            });

            taskData.Add(new TaskData {
                Id = 98,
                Subject = "UI Review Follow‑ups",
                StartTime = new DateTime(2026, 4, 24, 11, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 13, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "review",
                Progress = 99,
                Description = "Address UI review comments"
            });

            taskData.Add(new TaskData {
                Id = 99,
                Subject = "UX Improvement Implementation",
                StartTime = new DateTime(2026, 4, 24, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 15, 30, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "in-progress",
                Progress = 62,
                Description = "Implement UX improvements"
            });

            taskData.Add(new TaskData {
                Id = 100,
                Subject = "API Stability Validation",
                StartTime = new DateTime(2026, 4, 24, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 11, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Validate API stability"
            });
            taskData.Add(new TaskData {
                Id = 101,
                Subject = "Database Health Review",
                StartTime = new DateTime(2026, 4, 24, 11, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 13, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "review",
                Progress = 99,
                Description = "Review database health metrics"
            });

            taskData.Add(new TaskData {
                Id = 102,
                Subject = "Runtime Monitoring Adjustment",
                StartTime = new DateTime(2026, 4, 24, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 16, 0, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "in-progress",
                Progress = 55,
                Description = "Adjust runtime monitoring thresholds"
            });

            taskData.Add(new TaskData {
                Id = 103,
                Subject = "Regression Result Review",
                StartTime = new DateTime(2026, 4, 24, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 11, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "Review regression test results"
            });

            taskData.Add(new TaskData {
                Id = 104,
                Subject = "Automation Failure Analysis",
                StartTime = new DateTime(2026, 4, 24, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 13, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "review",
                Progress = 99,
                Description = "Analyze automation failures"
            });

            taskData.Add(new TaskData {
                Id = 105,
                Subject = "Bug Verification Cycle",
                StartTime = new DateTime(2026, 4, 24, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 16, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "in-progress",
                Progress = 48,
                Description = "Verify fixed bugs"
            });

            taskData.Add(new TaskData {
                Id = 106,
                Subject = "Build Consistency Check",
                StartTime = new DateTime(2026, 4, 24, 9, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 12, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "review",
                Progress = 99,
                Description = "Check build consistency"
            });

            taskData.Add(new TaskData {
                Id = 107,
                Subject = "Deployment Readiness Review",
                StartTime = new DateTime(2026, 4, 24, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 16, 0, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "in-progress",
                Progress = 60,
                Description = "Review deployment readiness"
            });

            taskData.Add(new TaskData {
                Id = 108,
                Subject = "Security Verification Review",
                StartTime = new DateTime(2026, 4, 24, 9, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 11, 30, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Review security verification results"
            });

            taskData.Add(new TaskData {
                Id = 109,
                Subject = "Compliance Observation Review",
                StartTime = new DateTime(2026, 4, 24, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 13, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "review",
                Progress = 99,
                Description = "Review compliance observations"
            });

            taskData.Add(new TaskData {
                Id = 110,
                Subject = "Risk Mitigation Execution",
                StartTime = new DateTime(2026, 4, 24, 14, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 16, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "in-progress",
                Progress = 44,
                Description = "Execute risk mitigation steps"
            });

            taskData.Add(new TaskData {
                Id = 111,
                Subject = "Sprint Outcome Review",
                StartTime = new DateTime(2026, 4, 24, 10, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 11, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Review sprint outcomes"
            });

            taskData.Add(new TaskData {
                Id = 112,
                Subject = "Release Decision Discussion",
                StartTime = new DateTime(2026, 4, 24, 12, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 13, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "review",
                Progress = 99,
                Description = "Discuss release decision"
            });

            taskData.Add(new TaskData {
                Id = 113,
                Subject = "Release Coordination",
                StartTime = new DateTime(2026, 4, 24, 14, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 15, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "in-progress",
                Progress = 58,
                Description = "Coordinate final release activities"
            });

            taskData.Add(new TaskData {
                Id = 114,
                Subject = "UAT Follow‑up Planning",
                StartTime = new DateTime(2026, 4, 24, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 18, 0, 0),
                EmployeeId = 1,
                EmployeeName = "Sarah",
                Status = "pending",
                Progress = 0,
                Description = "Plan UAT follow‑ups"
            });

            taskData.Add(new TaskData {
                Id = 115,
                Subject = "Production Checklist Prep",
                StartTime = new DateTime(2026, 4, 24, 16, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 17, 30, 0),
                EmployeeId = 2,
                EmployeeName = "John",
                Status = "pending",
                Progress = 0,
                Description = "Prepare production checklist"
            });

            taskData.Add(new TaskData {
                Id = 116,
                Subject = "Performance Review Notes",
                StartTime = new DateTime(2026, 4, 24, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 18, 0, 0),
                EmployeeId = 3,
                EmployeeName = "Emma",
                Status = "pending",
                Progress = 0,
                Description = "Prepare performance review notes"
            });

            taskData.Add(new TaskData {
                Id = 117,
                Subject = "Integration Follow‑ups",
                StartTime = new DateTime(2026, 4, 24, 16, 30, 0),
                EndTime = new DateTime(2026, 4, 24, 17, 30, 0),
                EmployeeId = 4,
                EmployeeName = "Michael",
                Status = "pending",
                Progress = 0,
                Description = "Track integration follow‑ups"
            });

            taskData.Add(new TaskData {
                Id = 118,
                Subject = "Security Closure Prep",
                StartTime = new DateTime(2026, 4, 24, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 18, 0, 0),
                EmployeeId = 5,
                EmployeeName = "Lisa",
                Status = "pending",
                Progress = 0,
                Description = "Prepare security closure"
            });

            taskData.Add(new TaskData {
                Id = 119,
                Subject = "Release Retrospective Planning",
                StartTime = new DateTime(2026, 4, 24, 15, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 16, 30, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "pending",
                Progress = 0,
                Description = "Plan release retrospective"
            });

            taskData.Add(new TaskData {
                Id = 120,
                Subject = "Post‑release Monitoring Setup",
                StartTime = new DateTime(2026, 4, 24, 17, 0, 0),
                EndTime = new DateTime(2026, 4, 24, 18, 0, 0),
                EmployeeId = 6,
                EmployeeName = "David",
                Status = "pending",
                Progress = 0,
                Description = "Setup post‑release monitoring"
            });
            return taskData;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string Location { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string CategoryColor { get; set; }
            public bool IsAllDay { get; set; }
        }

        public class TaskData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int EmployeeId { get; set; }
            public string Status { get; set; }
            public int Progress { get; set; }
            public string Description { get; set; }
            public string EmployeeName { get; set; }
        }
    }
}