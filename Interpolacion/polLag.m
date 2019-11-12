function [yi] = polLag(x, y, xi)
  n = length(x)-1;
  sm= 0;
  for i = 1 : n+1
    pr = 1;
    for j = 1 : n+1
      if j ~= i
        pr = pr * (xi - x(j))/(x(i) - x(j));
      endif
    endfor
    sm = sm + y(i) * pr;
  endfor
  disp(sm);
endfunction
