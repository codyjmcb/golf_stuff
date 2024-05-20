<?php

	require_once '../src/Router.php';
	require_once '../src/Controllers/HomeController.php';
	require_once '../src/Controllers/AboutController.php';

	$router = new Router();

	// Define routes
	$router->add('/', 'HomeController@index');
	$router->add('/about', 'AboutController@index');

	// run the router
	$router->dispatch($_SERVER['REQUEST_URI']);

?>
