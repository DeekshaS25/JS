/* styles.css */
body { 
	font-family: Arial, sans-serif; 
	margin: 0; 
	padding: 0; 
	background-color: #f4f4f4; 
} 

header { 
	width: 100%; 
	background-color: #333; 
	color: #fff; 
	text-align: center; 
	padding: 10px; 
} 

main { 
	max-width: 600px; 
	margin: 0 auto; 
	padding: 20px; 
} 

.bookmark-form { 
	display: flex; 
	margin-bottom: 10px; 
} 

input[type="url"] { 
	flex: 1; 
	padding: 10px; 
} 

button#addBookmark { 
	background-color: #007bff; 
	color: #fff; 
	border: none; 
	padding: 10px 20px; 
	cursor: pointer; 
	font-weight: 600; 
	margin-left: 6px; 
} 

button#addBookmark:hover { 
	background-color: #160af3; 
} 

button#deleteAll { 
	background-color: #ff6347; 
	color: #fff; 
	border: none; 
	padding: 10px 20px; 
	cursor: pointer; 
	margin-left: 10px; 
	font-weight: 600; 
} 

button#deleteAll:hover { 
	background-color: #f80404; 
} 

.bookmark-item { 
	background-color: #f5f5f5; 
	padding: 10px; 
	border: 2px solid #1d22b3; 
	border-radius: 5px; 
	display: flex; 
	justify-content: space-between; 
	align-items: center; 
	margin-bottom: 10px; 
	background-color: #e6f2f5; 
} 

.bookmark-item a { 
	text-decoration: none; 
	color: #0d0d0d; 
} 

.bookmark-item a:hover { 
	text-decoration: underline; 
} 

/* Style the "Delete" button */
.delete { 
	background-color: #ff6347; /* Red color */
	color: #fff; /* White text color */
	border: none; 
	padding: 5px 5px; 
	border-radius: 5px; 
	font-size: medium; 
	cursor: pointer; 
	margin-left: 5px; 
} 

.delete:hover { 
	background-color: #f80404; 
} 

.edit { 
	background-color: #6947ff; /* Red color */
	color: #fff; /* White text color */
	border: none; 
	padding: 5px 15px; 
	border-radius: 5px; 
	font-size: medium; 
	cursor: pointer; 
} 

.edit:hover { 
	background-color: #4b0da3; 
} 

ul { 
	list-style: none; 
	padding: 0; 
} 

li { 
	display: flex; 
	justify-content: space-between; 
	margin-bottom: 10px; 
} 

a { 
	text-decoration: none; 
	color: #333; 
} 

a:hover { 
	text-decoration: underline; 
	color: rgb(40, 130, 189); 
} 

@media (max-width: 768px) { 
	main { 
		padding: 10px; 
	} 

	.bookmark-form { 
		flex-direction: column; 
	} 

	input[type="url"], 
	button#addBookmark, 
	button#deleteAll { 
		margin-left: 0; 
		margin-bottom: 10px; 
	} 
} 

@media (max-width: 345px) { 
	main { 
		padding: 10px; 
	} 

	.bookmark-form { 
		flex-direction: column; 
	} 

	input[type="url"], 
	button#addBookmark, 
	button#deleteAll { 
		margin-left: 0; 
	} 
}
