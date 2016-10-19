program fizzbuzz
  implicit none

  integer :: i

  do i=1, 100
     if(mod(i, 15) .eq. 0) then
        write(*,*) 'FizzBuzz'
     elseif(mod(i, 3) .eq. 0) then
        write(*,*) 'Fizz'
     elseif(mod(i, 5) .eq. 0) then
        write(*,*) 'Buzz'
     else
        write(*,'(3I3)') i
     end if
  end do

end program fizzbuzz