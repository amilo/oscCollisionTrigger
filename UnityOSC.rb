live_loop :foo do
  ##| play 89
  
  use_real_time
  
  val = sync"/osc/sonicpi/unity/trigger"
  puts val
  if val[0] == "Start"
    ##| play 70
    ##| sleep 1
    ##| play 80
    ##| sleep 0.5
    ##| play 90
  end
  
  if val[0] == "Loopy"
    sample :ambi_piano
  end
  
  if val[0] == "Crash"
    sample :tabla_ghe1
  end
  
end
# Welcome to Sonic Pi v3.1

