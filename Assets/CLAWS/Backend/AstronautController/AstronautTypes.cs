using UnityEngine;


public class Location /// UNITY LOCATION ///
{
    public double posX; // X AXIS
    public double posY;
    public double posZ; // Y AXIS
    public double Heading;

    public Location() { }

    public Location(double posx, double posy, double posz, double heading)
    {
        this.posX = posx;
        this.posY = posy;
        this.posZ = posz;
        this.Heading = heading;
    }
    
        public override int GetHashCode()
        {
            return (posX, posY, posZ, Heading).GetHashCode();
        }
    

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Location otherLoc = (Location)obj;
        return posX == otherLoc.posX &&
               posY == otherLoc.posY &&
               posZ == otherLoc.posZ &&
               Heading == otherLoc.Heading;
    }
}