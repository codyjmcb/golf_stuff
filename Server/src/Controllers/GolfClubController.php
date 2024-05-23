<?php
	namespace App\Controller;

	use PDO;

	class GolfClubController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "GOLF_CLUBS";

		public function getGolfClubs()
		{
			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table");
				$rows = $stmt->fetchAll(PDO::FETCH_ASSOC);
				return json_encode($rows);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function getGolfClub()
		{
			$headers = getallheaders();

			$golferID = isset($headers['golferID']) ? $headers['golferID'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE golferID = \"$golferID\"");
				$rows = $stmt->fetchAll(PDO::FETCH_ASSOC);
				return json_encode($rows);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addGolfClub()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$uniqueID = $data['uniqueID'] ?? null;
			$golferID = $data['golferID'] ?? null;
			$clubID = $data['clubID'] ?? null;
			$lie = $data['lie'] ?? null;
			$make = $data['make'] ?? null;
			$model = $data['model'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO $this->table (golferID, clubID, lie, make, model) VALUES (\"$golferID\", \"$clubID\", \"$lie\", \"$make\", \"$model\")";
			$stmt = $db->prepare($query);

			if($stmt->execute())
			{
				return "Success";
			}
			else
			{
				return "Failure";
			}
		}

		public function updateGolfClub()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$uniqueID = $data['uniqueID'] ?? null;
			$golferID = $data['golferID'] ?? null;
			$clubID = $data['clubID'] ?? null;
			$lie = $data['lie'] ?? null;
			$make = $data['make'] ?? null;
			$model = $data['model'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET golferID = \"$golferID\", clubID = \"$clubID\", lie = \"$lie\", make = \"$make\", model = \"$model\" WHERE uniqueID = \"$uniqueID\"";
			$stmt = $db->prepare($query);
			if($stmt->execute())
			{
				return "Success";
			}
			else
			{
				return "Failure";
			}
		}

		public function deleteGolfClub()
		{
			$headers = getallheaders();
			$uniqueID = isset($headers['uniqueID']) ? $headers['uniqueID'] : null;
			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);

			$query = "DELETE FROM $this->table WHERE uniqueID = \"$uniqueID\"";
			$stmt = $db->prepare($query);

			if($stmt->execute())
			{
				return "Success";
			}
			else
			{
				return "Failure";
			}
		}
	}
?>