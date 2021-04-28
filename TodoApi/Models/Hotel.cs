using System;

namespace TodoApi
{
    public class Hotel
    {
     public int HotelId { get; set; }
     public String Name { get; set; }
     public String Website { get; set; }
     public String City { get; set; }
     public int Rating { get; set; }
     public String ImageUrl { get; set; }


    public Hotel(){}


    public Hotel(int id, String name, String website, String city, int rating, String url)
    {
        this.HotelId = id;
        
        this.Name
        = name;
                
        this.Website
        = website;
                
        this.City
        = city;
        this.Rating = rating;
        this.ImageUrl = url;
    }


    }
}