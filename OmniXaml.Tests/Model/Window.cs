﻿namespace OmniXaml.Tests.Model
{
    internal class Window
    {
        public string Title { get; set; }
        public object Content { get; set; }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Content)}: {Content}";
        }

        protected bool Equals(Window other)
        {
            return string.Equals(Title, other.Title) && Equals(Content, other.Content);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Window) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Title != null ? Title.GetHashCode() : 0)*397) ^ (Content != null ? Content.GetHashCode() : 0);
            }
        }
    }
}