﻿using System;
using System.Collections.Generic;

namespace Snake_Game_WPF
{
    public class Position
    {
        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row { get; }
        public int Col { get; }

        public override bool Equals(object? obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Col == position.Col;
        }

        public override int GetHashCode() => HashCode.Combine(Row, Col);

        public Position Translate(Direction dir) => new Position(Row + dir.RowOffset, Col + dir.ColOffset);

        public static bool operator ==(Position? left, Position? right) => EqualityComparer<Position>.Default.Equals(left, right);

        public static bool operator !=(Position? left, Position? right) => !(left == right);

    }
}
