﻿namespace OmniXaml.Tests.Model
{
    public class DataTemplate
    {
        public TemplateContent Content { get; set; }

        protected bool Equals(DataTemplate other)
        {
            return Equals(Content, other.Content);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((DataTemplate) obj);
        }

        public override int GetHashCode()
        {
            return (Content != null ? Content.GetHashCode() : 0);
        }
    }
}