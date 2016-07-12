//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amirhome.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public State()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.GoogleMaps = new HashSet<GoogleMap>();
            this.Images = new HashSet<Image>();
            this.Plans = new HashSet<Plan>();
            this.StreetViews = new HashSet<StreetView>();
            this.Features = new HashSet<Feature>();
        }
    
        public int ID { get; set; }
        public Nullable<int> OwnerID { get; set; }
        public Nullable<int> Province { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public Nullable<int> District { get; set; }
        public string Address { get; set; }
        public string DetailedAddress { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int Serial { get; set; }
        public string Condition { get; set; }
        public string StateType { get; set; }
        public string StatePosition { get; set; }
        public string Floors { get; set; }
        public string Floor { get; set; }
        public string Units { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public Nullable<double> MortgagePrice { get; set; }
        public Nullable<double> PrepaymentPrice { get; set; }
        public Nullable<double> Loan { get; set; }
        public Nullable<double> PricePerMeter { get; set; }
        public string CurrentStatus { get; set; }
        public Nullable<double> Age { get; set; }
        public string Facing { get; set; }
        public string Infosource { get; set; }
        public string Adjuster { get; set; }
        public string Docsituation { get; set; }
        public string Description { get; set; }
        public string Bedrooms { get; set; }
        public string Bathrooms { get; set; }
        public string Parking { get; set; }
        public string Kitchen { get; set; }
        public string Tells { get; set; }
        public string Terrace { get; set; }
        public string Flooring { get; set; }
        public Nullable<double> Width { get; set; }
        public Nullable<double> Area { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> Infrastructure { get; set; }
        public string Aggregate { get; set; }
        public string Crossing { get; set; }
        public string Reformative { get; set; }
        public string Usage { get; set; }
        public Nullable<bool> Changeable { get; set; }
        public string Occasion { get; set; }
        public Nullable<bool> OccasionFlag { get; set; }
        public Nullable<bool> Approved { get; set; }
        public Nullable<bool> Archived { get; set; }
        public Nullable<int> AgentID { get; set; }
        public string Cabinet { get; set; }
        public string AllUnits { get; set; }
        public string Privacy { get; set; }
    
        public virtual District District1 { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<GoogleMap> GoogleMaps { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual province province1 { get; set; }
        public virtual StateType StateType1 { get; set; }
        public virtual ICollection<StreetView> StreetViews { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
        public virtual User User { get; set; }
    }
}