#!/bin/bash

# Update package lists
sudo apt update

# Install Apache
sudo apt install apache2 -y

# Install MySQL and set root password
sudo apt install mysql-server -y
sudo mysql_secure_installation

# Install PHP and required modules
sudo apt install php libapache2-mod-php php-mysql -y

# Restart Apache to apply changes
sudo systemctl restart apache2

# Display information about installed components
echo "LAMP stack installation completed."
echo "Apache installed and running."
echo "MySQL installed and secured."
echo "PHP installed."

# Optional: Provide MySQL root password for convenience
echo "MySQL root password (make a note of this):"
sudo cat /etc/mysql/debian.cnf | grep password | head -n 1 | awk '{print $3}'
