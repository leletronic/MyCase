﻿namespace LGG.MyCase.Domain.Entities
{
    public class Style
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}