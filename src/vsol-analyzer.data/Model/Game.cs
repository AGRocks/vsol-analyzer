using System;

namespace vsol_analyzer.data.Model
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Info { get; set; }
        public string Result { get; set; }
        public TeamGameStatistics Home { get; set; }
        public TeamGameStatistics Away { get; set; }
    }
}
