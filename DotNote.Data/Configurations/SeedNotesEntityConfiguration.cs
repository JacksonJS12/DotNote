﻿using DotNote.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNote.Data.Configurations
{
    public class SeedNotesEntityConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasData(this.GenerateNotes());
        }
        private List<Note> GenerateNotes()
        {
            var generateNotes = new List<Note>();

            var note1 = new Note
            {
                Title = "First Note",
                Subtitle = "This is the subtitle for the first note",
                Text = "This is the content of the first note.",
                CreatedAt = DateTime.UtcNow,
                //UpdatedAt = DateTime.UtcNow, // Assuming UpdatedAt should be set to the creation time initially
                IsActive = true,
                UserId = Guid.Parse("0f129c2a-ada6-452c-a557-d5b11e9373e2")
            };
            generateNotes.Add(note1);

            var note2 = new Note
            {
                Title = "Second Note",
                Subtitle = "This is the subtitle for the second note",
                Text = "This is the content of the second note.",
                CreatedAt = DateTime.UtcNow,
                //UpdatedAt = DateTime.UtcNow, // Assuming UpdatedAt should be set to the creation time initially
                IsActive = true,
                UserId = Guid.Parse("0f129c2a-ada6-452c-a557-d5b11e9373e2")
            };
            generateNotes.Add(note2);

            var note3 = new Note
            {
                Title = "Third Note",
                Subtitle = "This is the subtitle for the third note",
                Text = "This is the content of the third note.",
                CreatedAt = DateTime.UtcNow,
                //UpdatedAt = DateTime.UtcNow, // Assuming UpdatedAt should be set to the creation time initially
                IsActive = true,
                UserId = Guid.Parse("0f129c2a-ada6-452c-a557-d5b11e9373e2")
            };
            generateNotes.Add(note3);

            return generateNotes;
        }
    }
}
