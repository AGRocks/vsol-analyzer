using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsol_analyzer.data.Model
{
    public class TeamGameStatistics
    {
        public Guid Id { get; set; }
        public string Formation { get; set; }
        public int Up { get; set; }
        public int Down { get; set; }
        public string Tactic { get; set; }
        public string Style { get; set; }
        public string DefenceType { get; set; }
        public string Defence { get; set; }
        public string Brutality { get; set; }
        public string GameFocus { get; set; }
        public int Opt1 { get; set; }
        public int Opt2 { get; set; }
        public int StrengRatio { get; set; }
        public int Teamwork { get; set; }
        public int Shots { get; set; }
        public int Corners { get; set; }
        public int Freekicks { get; set; }
        public int Penalty { get; set; }
        public int Offside { get; set; }
        public int ForecastStrength { get; set; }
        public int ForecastStrengthPercent { get; set; }
        public int ActualStrength { get; set; }
        public int ActualStrengthPercent { get; set; }
        public int StartStrength { get; set; }
        public int StartStrengthPercent { get; set; }
        public int StrengthInTheBeginning { get; set; }
        public int StrengthInTheBeginningPercent { get; set; }
        public int StrengthInTheEnd { get; set; }
        public int StrengthInTheEndPercent { get; set; }
        public List<string> Positions { get; set; }
    }
}
