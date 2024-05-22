<?php

	require_once '../src/Router.php';
	require_once '../src/Controllers/ApiController.php';
	require_once '../src/Controllers/GolferController.php';
	require_once '../src/Controllers/ClubTypeController.php';
	require_once '../src/Controllers/GolfCourseController.php';

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

	// POST ROUTES
	$router->add('POST', '/golfer', 'GolferController@addGolfer');
	$router->add('POST', '/clubtype', 'ClubTypeController@addClubType');
	$router->add('POST', '/golfcourse', 'GolfCourseController@addGolfCourse');
	
	// PUT ROUTES
	$router->add('PUT', '/golfer', 'GolferController@updateGolfer');
	$router->add('PUT', '/clubtype', 'ClubTypeController@updateClubType');
	$router->add('PUT', '/golfcourse', 'GolfCourseController@updateGolfCourse');

	// DELETE ROUTES
	$router->add('DELETE', '/golfer', 'GolferController@deleteGolfer');
	$router->add('DELETE', '/clubtype', 'ClubTypeController@deleteClubType');
	$router->add('DELETE', '/golfcourse', 'GolfCourseController@deleteGolfCourse');

	// run the router
	$method = $_SERVER['REQUEST_METHOD'];
	$uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);
	echo $router->dispatch($method, $uri);
?>
