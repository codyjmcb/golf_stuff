<?php
	namespace App\Controller;

	use PDO;

	class TeeInformationController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "TEE_INFORMATION";

		public function getTeeInformations()
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

		public function getTeeInformation()
		{
			$headers = getallheaders();

			$uniqueID = isset($headers['uniqueID']) ? $headers['uniqueID'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE uniqueID = \"$uniqueID\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addTeeInformation()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$courseID = $data['courseID'] ?? null;
			$teeName = $data['teeName'] ?? null;
			$yardage = $data['yardage'] ?? null;
			$rating = $data['rating'] ?? null;
			$slope = $data['slope'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO $this->table (courseID, teeName, yardage, rating, slope) VALUES (\"$courseID\", \"$teeName\", $yardage, $rating, $slope)";
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

		public function updateTeeInformation()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$uniqueID = $data['uniqueID'] ?? null;
			$courseID = $data['courseID'] ?? null;
			$teeName = $data['teeName'] ?? null;
			$yardage = $data['yardage'] ?? null;
			$rating = $data['rating'] ?? null;
			$slope = $data['slope'] ?? null;


			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET courseID = \"$courseID\", teeName = \"$teeName\", yardage = $yardage, rating = $rating, slope = $slope WHERE uniqueID = \"$uniqueID\"";
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

		public function deleteTeeInformation()
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