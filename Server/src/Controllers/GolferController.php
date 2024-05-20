<?php

	namespace App\Controller;

	class GolferController
	{
		public function getGolfers()
		{
			return "This will become a list of all golfers";
		}

		public function getGolfer()
		{
			$headers = getallheaders();

			$golferId = isset($headers['golferId']) ? $headers['golferId'] : null;

			if($golferId)
			{
				return "Hello, golfer id is $golferId";
			}
			else
			{
				return "Failed to fetch golfer id";
			}
		}

		public function addGolfer()
		{
			return "Add Golfer";
		}

		public function updateGolfer()
		{
			return "Update Golfer";
		}

		public function deleteGolfer()
		{
			return "Delete Golfer";
		}
	}
?>
