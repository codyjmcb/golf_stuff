<?php

	namespace App\Controller;

	class ApiController
	{
		public function getHome()
		{
			return "Hello World";
		}

		public function getJson()
		{
			header('Content-Type: application/json');
			return json_encode(['message' => 'Hello, this is a JSON response!']);
		}

		public function getAbout()
		{
			return "Welcome to about";
		}
	}

?>
