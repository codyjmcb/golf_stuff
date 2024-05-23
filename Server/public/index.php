<?php

	require_once '../src/Router.php';
	require_once '../src/Controllers/ApiController.php';
	require_once '../src/Controllers/GolferController.php';
	require_once '../src/Controllers/ClubTypeController.php';
	require_once '../src/Controllers/GolfCourseController.php';
	require_once '../src/Controllers/TeeInformationController.php';
	require_once '../src/Controllers/GolfClubController.php';

	$router = new Router();

	// Define routes
	// GET ROUTES
	$router->add('GET', '/', 'ApiController@getHome');
	$router->add('GET', '/home', 'ApiController@getHome');
	$router->add('GET', '/test', 'ApiController@getJson');
	$router->add('GET', '/about', 'ApiController@getAbout');
	
	$router->add('GET', '/golfers', 'GolferController@getGolfers');
	$router->add('GET', '/golfer', 'GolferController@getGolfer');
	$router->add('GET', '/clubtypes', 'ClubTypeController@getClubTypes');
	$router->add('GET', '/clubtype', 'ClubTypeController@getClubType');
	$router->add('GET', '/golfcourses', 'GolfCourseController@getGolfCourses');
	$router->add('GET', '/golfcourse', 'GolfCourseController@getGolfCourse');
	$router->add('GET', '/teeinformations', 'TeeInformationController@getTeeInformations');
	$router->add('GET', '/teeinformation', 'TeeInformationController@getTeeInformation');
	$router->add('GET', '/golfcourse/teeinformation', 'TeeInformationController@getTeeInformationForCourse');
	$router->add('GET', '/golfclubs', 'GolfClubController@getGolfClubs');
	$router->add('GET', '/golfclub', 'GolfClubController@getGolfClub');

	// POST ROUTES
	$router->add('POST', '/golfer', 'GolferController@addGolfer');
	$router->add('POST', '/clubtype', 'ClubTypeController@addClubType');
	$router->add('POST', '/golfcourse', 'GolfCourseController@addGolfCourse');
	$router->add('POST', '/teeinformation', 'TeeInformationController@addTeeInformation');
	$router->add('POST', '/golfclub', 'GolfClubController@addGolfClub');

	// PUT ROUTES
	$router->add('PUT', '/golfer', 'GolferController@updateGolfer');
	$router->add('PUT', '/clubtype', 'ClubTypeController@updateClubType');
	$router->add('PUT', '/golfcourse', 'GolfCourseController@updateGolfCourse');
	$router->add('PUT', '/teeinformation', 'TeeInformationController@updateTeeInformation');
	$router->add('PUT', '/golfclub', 'GolfClubController@updateGolfClub');

	// DELETE ROUTES
	$router->add('DELETE', '/golfer', 'GolferController@deleteGolfer');
	$router->add('DELETE', '/clubtype', 'ClubTypeController@deleteClubType');
	$router->add('DELETE', '/golfcourse', 'GolfCourseController@deleteGolfCourse');
	$router->add('DELETE', '/teeinformation', 'TeeInformationController@deleteTeeInformation');
	$router->add('DELETE', '/golfclub', 'GolfClubController@deleteGolfClub');

	// run the router
	$method = $_SERVER['REQUEST_METHOD'];
	$uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);
	echo $router->dispatch($method, $uri);
?>
