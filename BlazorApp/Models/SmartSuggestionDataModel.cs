namespace BlazorApp.Models
{
    public class SmartSuggestionDataModel
    {
        // The title of the task.
        public string Title { get; set; }

        // The current status of the task.
        public string Status { get; set; }

        // The color associated with the task for visual representation.
        public string Color { get; set; }

        // A detailed description of the task.
        public string Description { get; set; }

        // The story points for the task, representing its complexity or effort.
        public int StoryPoints { get; set; }
    }
}

