function sonEquidistantes(x,y)
  n = length(x);
  f = 1;
  if n > 3
    d1 = x(2) - x(1);
    d2 = y(2) - y(1);
    for i = 2 : n - 1
      dif1 = x(i+1) - x(i);
      dif2 = y(i+1) - y(i);
      if dif1 ~= d1 || dif2~=d2
        f = 0;
        disp(f);
        return;
      endif
    endfor
   endif
  disp(f);
endfunction
