<?php
// This script and data application were generated by AppGini 5.70
// Download AppGini for free from https://bigprof.com/appgini/download/

	$currDir=dirname(__FILE__);
	include("$currDir/defaultLang.php");
	include("$currDir/language.php");
	include("$currDir/lib.php");

	handle_maintenance();

	header('Content-type: text/javascript; charset=' . datalist_db_encoding);

	$table_perms = getTablePermissions('Return');
	if(!$table_perms[0]){ die('// Access denied!'); }

	$mfk=$_GET['mfk'];
	$id=makeSafe($_GET['id']);
	$rnd1=intval($_GET['rnd1']); if(!$rnd1) $rnd1='';

	if(!$mfk){
		die('// No js code available!');
	}

	switch($mfk){

		case 'Book_Number':
			if(!$id){
				?>
				$('Book_Title<?php echo $rnd1; ?>').innerHTML='&nbsp;';
				$('Issue_Date<?php echo $rnd1; ?>').innerHTML='&nbsp;';
				$('Due_Date<?php echo $rnd1; ?>').innerHTML='&nbsp;';
				<?php
				break;
			}
			$res = sql("SELECT `Book_Issue`.`id` as 'id', `Book_Issue`.`issue_id` as 'issue_id', IF(    CHAR_LENGTH(`Users1`.`Name`), CONCAT_WS('',   `Users1`.`Name`), '') as 'Member', IF(    CHAR_LENGTH(`Users1`.`Membership_Number`), CONCAT_WS('',   `Users1`.`Membership_Number`), '') as 'Number', IF(    CHAR_LENGTH(`books1`.`ISBN_NO`), CONCAT_WS('',   `books1`.`ISBN_NO`), '') as 'Book_Number', IF(    CHAR_LENGTH(`books1`.`Book_Title`), CONCAT_WS('',   `books1`.`Book_Title`), '') as 'Book_Title', if(`Book_Issue`.`Issue_Date`,date_format(`Book_Issue`.`Issue_Date`,'%m/%d/%Y'),'') as 'Issue_Date', if(`Book_Issue`.`Return_Date`,date_format(`Book_Issue`.`Return_Date`,'%m/%d/%Y'),'') as 'Return_Date', `Book_Issue`.`Status` as 'Status' FROM `Book_Issue` LEFT JOIN `Users` as Users1 ON `Users1`.`id`=`Book_Issue`.`Member` LEFT JOIN `books` as books1 ON `books1`.`id`=`Book_Issue`.`Book_Number`  WHERE `Book_Issue`.`id`='$id' limit 1", $eo);
			$row = db_fetch_assoc($res);
			?>
			$j('#Book_Title<?php echo $rnd1; ?>').html('<?php echo addslashes(str_replace(array("\r", "\n"), '', nl2br($row['Book_Title']))); ?>&nbsp;');
			$j('#Issue_Date<?php echo $rnd1; ?>').html('<?php echo addslashes(str_replace(array("\r", "\n"), '', nl2br($row['Issue_Date']))); ?>&nbsp;');
			$j('#Due_Date<?php echo $rnd1; ?>').html('<?php echo addslashes(str_replace(array("\r", "\n"), '', nl2br($row['Return_Date']))); ?>&nbsp;');
			<?php
			break;

		case 'Member':
			if(!$id){
				?>
				$('Number<?php echo $rnd1; ?>').innerHTML='&nbsp;';
				<?php
				break;
			}
			$res = sql("SELECT `Users`.`id` as 'id', `Users`.`Membership_Number` as 'Membership_Number', `Users`.`Name` as 'Name', `Users`.`Contact` as 'Contact', `Users`.`ID_Number` as 'ID_Number' FROM `Users`  WHERE `Users`.`id`='$id' limit 1", $eo);
			$row = db_fetch_assoc($res);
			?>
			$j('#Number<?php echo $rnd1; ?>').html('<?php echo addslashes(str_replace(array("\r", "\n"), '', nl2br($row['Membership_Number']))); ?>&nbsp;');
			<?php
			break;


	}

?>