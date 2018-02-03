<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>

    <?php
      if(isset($_GET['num'])) {
        $num = intval($_GET['num']);
        $beforePrevious = 1;
        $previous = 0;
        $current = 0;
        $next = 0;
        $counter = 0;

        while ($counter < $num) {
          $next = $current + $previous + $beforePrevious;
          echo $next . "\n";
          $beforePrevious = $previous;
          $previous = $current;
          $current = $next;
          $counter++;
        }
      }
     ?>
</body>
</html>
