<?php
	namespace App\Controller;

	use PDO;

	class ClubTypeController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "CLUB_TYPES";

		public function getClubTypes()
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

		public function getClubType()
		{
			$headers = getallheaders();

			$uniqueId = isset($headers['uniqueId']) ? $headers['uniqueId'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE uniqueId = \"$uniqueId\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addClubType()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$clubName = $data['clubName'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO $this->table (clubName) VALUES (\"$clubName\")";
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

		public function updateClubType()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$uniqueId = $data['uniqueId'] ?? null;
			$clubName = $data['clubName'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET clubName = \"$clubName\" WHERE uniqueId = \"$uniqueId\"";
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

		public function deleteClubType()
		{
			$headers = getallheaders();
			$uniqueId = isset($headers['uniqueId']) ? $headers['uniqueId'] : null;
			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);

			$query = "DELETE FROM $this->table WHERE uniqueId = \"$uniqueId\"";
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