// Zach Dillion
// James Odjewuyi
// Program 5
// Space Objects
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceObjects;

namespace Program5
{
    public partial class SpaceObjectForm : Form
    {
        // Declaring an array of 6 space objects
        SpaceObject[] spaceObjects = new SpaceObject[6];
        public SpaceObjectForm()
        {
            InitializeComponent();
        }

        // Event handler for selecting earthling from the list of objects
        // Displays the earthling creator group box while hiding other group boxes 
        private void earthlingButton_CheckedChanged(object sender, EventArgs e)
        {
            earthlingBox.Enabled = true;
            earthlingBox.Visible = true;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
            probeBox.Enabled = false;
            probeBox.Visible = false;
        }

        // Event handler for selecting martian from the list of objects
        // Displays the martian creator group box and hides others
        private void martianButton_CheckedChanged_1(object sender, EventArgs e)
        {
            martianBox.Enabled = true;
            martianBox.Visible = true;
            earthlingBox.Visible = false;
            earthlingBox.Enabled = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
            probeBox.Enabled = false;
            probeBox.Visible = false;
        }

        // Event handler for selecting planet from the list
        // Displays the planet creator group box and hides the others
        private void planetButton_CheckedChanged(object sender, EventArgs e)
        {
            planetBox.Enabled = true;
            planetBox.Visible = true;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
            probeBox.Enabled = false;
            probeBox.Visible = false;
        }

        // Event handler for when star is selected from the list of objects
        // Displays the star creator group box and hides others
        private void starButton_CheckedChanged(object sender, EventArgs e)
        {
            starBox.Enabled = true;
            starBox.Visible = true;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
            probeBox.Enabled = false;
            probeBox.Visible = false;
        }

        // Event handler for when spaceship is selected
        // Displays the spaceship creator group box and hides the rest
        private void shipButton_CheckedChanged(object sender, EventArgs e)
        {
            shipBox.Enabled = true;
            shipBox.Visible = true;
            starBox.Enabled = false;
            starBox.Visible = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            probeBox.Enabled = false;
            probeBox.Visible = false ;
        }

        // Event handler for when probe is selected
        // Displays the probe creator group box and hides the others
        private void probeButton_CheckedChanged(object sender, EventArgs e)
        {
            shipBox.Enabled = false;
            shipBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            probeBox.Enabled = true;
            probeBox.Visible = true;
        }

        // Event handler for when the user clicks the button to create an earthling
        // instantiates a new earthling to be created in the spaceObjects array
        // takes in input entered by the user, and displays the final group box
        // which shows a picture and a comprehensive string output of the earthling object
        private void earthlingCreateButton_Click(object sender, EventArgs e)
        {
            // validates user inputs for Earthling creation
            if (!int.TryParse(earthlingXBox.Text, out int x) ||
                !int.TryParse(earthlingYBox.Text, out int y) ||
                !int.TryParse(earthlingZBox.Text, out int z) ||
                !double.TryParse(earthlingHeightBox.Text, out double height) ||
                !int.TryParse(earthlingArmBox.Text, out int arms) ||
                !double.TryParse(earthlingSpeedBox.Text, out double speed))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            try
            {
                // Displays Earthling properties 
                spaceObjects[0] = new Earthling(x, y, z, height, arms, speed);
                earthlingOutLabel.Text = spaceObjects[0].ToString() +
                    $"\nComputed Property: {spaceObjects[0].ComputeProperty():F2}";

                // Displays total number of Earthlings
                earthlingCountLabel.Text = Earthling.EarthlingCount.ToString();

                // Hides other output boxes and displays Earthling output box
                earthlingOutBox.Enabled = true;
                earthlingOutBox.Visible = true;
                martianOutBox.Enabled = false;
                martianOutBox.Visible = false;
                planetOutBox.Enabled = false;
                planetOutBox.Visible = false;
                shipOutBox.Enabled = false;
                shipOutBox.Visible = false;
                probeOutBox.Enabled = false;
                probeOutBox.Visible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Earthling: {ex.Message}");
            }
        }

        // Event handler for when the user clicks the button to create a martian
        // instantiates a new martian to be created in the spaceObjects array
        // takes in input entered by the user, and displays the final group box
        // which shows a picture and a comprehensive string output of the martian object
        private void martianCreateButton_Click(object sender, EventArgs e)
        {
            // validates user inputs for Martian creation
            if (!int.TryParse(martianXBox.Text, out int x) ||
                !int.TryParse(martianYBox.Text, out int y) ||
                !int.TryParse(martianZBox.Text, out int z) ||
                !double.TryParse(martianHeightBox.Text, out double height) ||
                !int.TryParse(martianArmBox.Text, out int arms) ||
                !double.TryParse(martianTeleportBox.Text, out double teleportRange))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            try
            {
                // Displays Martian properties
                spaceObjects[1] = new Martian(x, y, z, height, arms, teleportRange);
                martianOutLabel.Text = spaceObjects[1].ToString() +
                    $"\nComputed Property: {spaceObjects[1].ComputeProperty():F2}";

                // Displays total number of Martians
                martianCountLabel.Text = Martian.MartianCount.ToString();
                
                // Hides other output boxes and displays Martian output box
                martianOutBox.Enabled = true;
                martianOutBox.Visible = true;
                earthlingOutBox.Enabled = false;
                earthlingOutBox.Visible = false;
                planetOutBox.Enabled = false;
                planetOutBox.Visible = false;
                shipOutBox.Enabled = false;
                shipOutBox.Visible = false;
                starOutBox.Enabled = false;
                starOutBox.Visible = false;
                probeOutBox.Enabled = false;
                probeOutBox.Visible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Martian: {ex.Message}");
            }
        }

        // Event handler for when the user clicks the button to create a planet
        // instantiates a new planet to be created in the spaceObjects array
        // takes in input entered by the user, and displays the final group box
        // which shows a picture and a comprehensive string output of the planet object
        private void planetCreateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(planetXBox.Text, out int x) ||
                !int.TryParse(planetYBox.Text, out int y) ||
                !int.TryParse(planetZBox.Text, out int z) ||
                !double.TryParse(planetRadiusBox.Text, out double radius) ||
                !int.TryParse(planetMoonBox.Text, out int moons))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            // Parse boolean values separately
            if (!bool.TryParse(planetWaterBox.Text, out bool hasWater) ||
                !bool.TryParse(planetAtmosBox.Text, out bool hasAtmosphere))
            {
                MessageBox.Show("Please enter 'true' or 'false' for water and atmosphere fields.");
                return;
            }

            try
            {
                // Displays Planet properties
                spaceObjects[2] = new Planet(x, y, z, radius, hasWater, moons, hasAtmosphere);
                planetOutLabel.Text = spaceObjects[2].ToString() +
                    $"\nComputed Property: {spaceObjects[2].ComputeProperty():F2}";

                // Displays total number of Planets
                planetCountLabel.Text = Planet.PlanetCount.ToString();

                // Hides other output boxes and displays planet output box
                martianOutBox.Enabled = false;
                martianOutBox.Visible = false;
                earthlingOutBox.Enabled = false;
                earthlingOutBox.Visible = false;
                planetOutBox.Enabled = true;
                planetOutBox.Visible = true;
                shipOutBox.Enabled = false;
                shipOutBox.Visible = false;
                starOutBox.Enabled = false;
                starOutBox.Visible = false;
                probeOutBox.Enabled = false;
                probeOutBox.Visible = false;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Planet: {ex.Message}");
            }
        }

        // Event handler for when the user clicks the button to create a star
        // instantiates a new star to be created in the spaceObjects array
        // takes in input entered by the user, and displays the final group box
        // which shows a picture and a comprehensive string output of the star object
        private void starCreateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(starXBox.Text, out int x) ||
                !int.TryParse(starYBox.Text, out int y) ||
                !int.TryParse(starZBox.Text, out int z) ||
                !double.TryParse(starRadiusBox.Text, out double radius) ||
                !double.TryParse(starTempBox.Text, out double temperature) ||
                !double.TryParse(starLumBox.Text, out double luminosity))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            try
            {
                // Displays Star properties
                spaceObjects[3] = new Star(x, y, z, radius, temperature, luminosity);
                starOutLabel.Text = spaceObjects[3].ToString() +
                $"\nComputed Property: {spaceObjects[3].ComputeProperty():F2}";

                // Displays total number of Stars
                starCountLabel.Text = Star.StarCount.ToString();

                // Hides other output boxes and displays Star output box
                martianOutBox.Enabled = false;
                martianOutBox.Visible = false;
                earthlingOutBox.Enabled = false;
                earthlingOutBox.Visible = false;
                planetOutBox.Enabled = false;
                planetOutBox.Visible = false;
                shipOutBox.Enabled = false;
                shipOutBox.Visible = false;
                starOutBox.Enabled = true;
                starOutBox.Visible = true;
                probeOutBox.Enabled = false;
                probeOutBox.Visible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Star: {ex.Message}");
            }
        }

        // Event handler for when the user clicks the button to create a spaceship
        // instantiates a new spaceship to be created in the spaceObjects array
        // takes in input entered by the user, and displays the final group box
        // which shows a picture and a comprehensive string output of the spaceship object
        private void shipCreateButton_Click(object sender, EventArgs e)
        {
            // validate user inputs for SpaceShip creation
            if (!int.TryParse(shipXBox.Text, out int x) ||
                !int.TryParse(shipYBox.Text, out int y) ||
                !int.TryParse(shipZBox.Text, out int z) ||
                !double.TryParse(shipPayloadBox.Text, out double payload) ||
                !double.TryParse(shipFuelBox.Text, out double fuel) ||
                !double.TryParse(shipSpeedBox.Text, out double speed) ||
                !int.TryParse(shipCrewBox.Text, out int crew))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            // check if ship type is provided
            if (string.IsNullOrWhiteSpace(shipTypeBox.Text))
            {
                MessageBox.Show("Please enter a ship type.");
                return;
            }

            try
            {
                // instatiates a spaceship object 
                spaceObjects[4] = new SpaceShip(x, y, z, shipTypeBox.Text, payload, fuel, speed, crew);

                // uses Tostring to print information
                shipOutLabel.Text = spaceObjects[4].ToString() +
                    $"\nComputed Property: {spaceObjects[4].ComputeProperty():F2}";

                // Displays total number of ships
                shipCountLabel.Text = SpaceShip.SpaceShipCount.ToString();

                // Displays Spaceship output box and hides others
                martianOutBox.Enabled = false;
                martianOutBox.Visible = false;
                earthlingOutBox.Enabled = false;
                earthlingOutBox.Visible = false;
                planetOutBox.Enabled = false;
                planetOutBox.Visible = false;
                shipOutBox.Enabled = true;
                shipOutBox.Visible = true;
                starOutBox.Enabled = false;
                starOutBox.Visible = false;
                probeOutBox.Enabled = false;
                probeOutBox.Visible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating SpaceShip: {ex.Message}");
            }
        }

        private void probeCreateButton_Click(object sender, EventArgs e)
        {
            // validate user inputs for Probe creation
            if (!int.TryParse(probeXBox.Text, out int x) ||
                !int.TryParse(probeYBox.Text, out int y) ||
                !int.TryParse(probeZBox.Text, out int z))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            // check if mission type is provided
            if (string.IsNullOrWhiteSpace(probeMissionBox.Text))
            {
                MessageBox.Show("Please enter a mission objective.");
                return;
            }

            try
            {
                // instatiates a spaceship object 
                spaceObjects[5] = new Probe(x, y, z, probeMissionBox.Text);

                // uses Tostring to print information
                probeOutLabel.Text = spaceObjects[5].ToString() +
                    $"\nComputed Property: {spaceObjects[5].ComputeProperty():F2}";

                // Displays total number of Probes
                probeCountLabel.Text = Probe.ProbeCount.ToString();

                // Shows Probe output box and hides others
                probeOutBox.Enabled = true;
                probeOutBox.Visible = true;
                martianOutBox.Enabled = false;
                martianOutBox.Visible = false;
                earthlingOutBox.Enabled = false;
                earthlingOutBox.Visible = false;
                planetOutBox.Enabled = false;
                planetOutBox.Visible = false;
                shipOutBox.Enabled = false;
                shipOutBox.Visible = false;
                starOutBox.Enabled = false;
                starOutBox.Visible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Invalid value: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Probe: {ex.Message}");
            }
        }
    }
}
