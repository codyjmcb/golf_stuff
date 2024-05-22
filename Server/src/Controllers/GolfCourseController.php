<?php
	namespace App\Controller;

	use PDO;

	class GolfCourseController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "GOLF_COURSES";

		public function getGolfCourses()
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

		public function getGolfCourse()
		{
			$headers = getallheaders();

			$courseID = isset($headers['courseID']) ? $headers['courseID'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE courseID = \"$courseID\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addGolfCourse()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$courseID = $data['courseID'] ?? null;
			$courseName = $data['courseName'] ?? null;
			$numTees = $data['numTees'] ?? null;
			$par = $data['par'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO $this->table VALUES (\"$courseID\", \"$courseName\", $numTees, $par)";
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

		public function updateGolfCourse()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$courseID = $data['courseID'] ?? null;
			$courseName = $data['courseName'] ?? null;
			$numTees = $data['numTees'] ?? null;
			$par = $data['par'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET courseName = \"$courseName\", numTees = $numTees, par = $par WHERE courseID = \"$courseID\"";
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

		public function deleteGolfCourse()
		{
			$headers = getallheaders();
			$courseID = isset($headers['courseID']) ? $headers['courseID'] : null;
			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);

			$query = "DELETE FROM $this->table WHERE courseID = \"$courseID\"";
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