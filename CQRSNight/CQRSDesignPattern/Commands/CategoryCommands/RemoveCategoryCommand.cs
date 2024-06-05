﻿namespace CQRSNight.CQRSDesignPattern.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int CategoryId { get; set; }
        public RemoveCategoryCommand(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}